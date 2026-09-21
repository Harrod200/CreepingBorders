#!/usr/bin/env python3
"""
BakeBorderDistanceCache.py — offline regeneration of BorderDistanceCache.csv.

Vectorized NumPy mirror of GeographicPolygonMath's edge-to-edge methodology
(float64; runtime uses float32):

  - unit vectors from (lon, lat) radians: (cosLat*cosLon, cosLat*sinLon, sinLat)
  - every VERTEX of A projected onto every EDGE of B and vice versa
  - PointToArcDistance: cross(a0,a1) normal, plane projection, hemisphere check
    (Dot(p, closest) > 0), OnArc orientation test, endpoint fallback for
    degenerate or off-arc cases
  - distance = R * acos(clamp(dot(p, closest))), R = 6371.0 km
  - PairKey canonical ordering; one row per unordered pair
  - early exit semantics preserved (a touching pair reports 0.0)

Input : Cached Data/PolygonCache.csv  (REGION/VERTEX lines, radians)
Output: Cached Data/BorderDistanceCache.csv (3-column A,B,distance)

Usage:  python3 Tools/BakeBorderDistanceCache.py [in.csv] [out.csv]
"""
import sys, math, time
import numpy as np

R_KM = 6371.0
CHUNK = 128

def load(path):
    regions = {}
    for line in open(path, encoding="utf-8"):
        p = line.rstrip("\n").split(",")
        if not p or p[0] == "#":
            continue
        if p[0] == "REGION":
            regions[p[1]] = []
        elif p[0] == "VERTEX":
            regions[p[1]].append((float(p[4]), float(p[5])))
    return regions

def unit_vecs(pts):
    arr = np.asarray(pts, dtype=np.float32)
    lon, lat = arr[:, 0], arr[:, 1]
    cl = np.cos(lat)
    return np.stack([cl * np.cos(lon), cl * np.sin(lon), np.sin(lat)], axis=1)

def _acos_clamp(x):
    return np.arccos(np.clip(x, -1.0, 1.0))

def _sweep_chunk(Pc, E0, E1, dot01, cross01, nlen, nh):
    """One chunk of P vs all edges of E. Returns min candidate distance."""
    m = len(Pc)
    pdotn = Pc @ nh.T                                   # (c,n)
    proj = Pc[:, None, :] - pdotn[:, :, None] * nh[None, :, :]
    plen = np.linalg.norm(proj, axis=2)
    plen_safe = np.where(plen > 1e-10, plen, 1.0)
    closest = proj / plen_safe[:, :, None]

    Pexp = np.broadcast_to(Pc[:, None, :], closest.shape)
    p_dot_closest = np.einsum("mnc,mnc->mn", Pexp, closest)

    v_dot_a0 = np.einsum("mnc,nc->mn", closest, E0)
    v_dot_a1 = np.einsum("mnc,nc->mn", closest, E1)
    full = np.broadcast_to(cross01[None, :, :], closest.shape)
    first = np.cross(E0[None, :, :], closest)
    second = np.cross(closest, E1[None, :, :])
    dot_full_first = np.einsum("mnc,mnc->mn", full, first)
    dot_full_second = np.einsum("mnc,mnc->mn", full, second)
    same_orient = (dot_full_first >= -1e-9) & (dot_full_second >= -1e-9)
    far_side = (v_dot_a0 < 0.0) & (v_dot_a1 < 0.0)
    on_arc = same_orient & ~far_side
    long_arc = dot01[None, :] <= 0.0
    on_arc = np.where(long_arc, (v_dot_a0 >= 0.0) | (v_dot_a1 >= 0.0), on_arc)

    valid = (dot01[None, :] <= 1.0 - 1e-9) & (nlen[None, :] > 1e-10) & (plen > 1e-10) \
            & (p_dot_closest > 0.0) & on_arc
    arc_dist = R_KM * _acos_clamp(p_dot_closest)
    d0 = R_KM * _acos_clamp(Pc @ E0.T)          # (m,n): Pc is (m,3), E0.T is (3,n) — correct
    d1 = R_KM * _acos_clamp(Pc @ E1.T)
    endpt = np.minimum(d0, d1)
    cand = np.where(valid, arc_dist, endpt)
    return float(cand.min())

def _sweep(P, E):
    """Min over all vertices of P vs all edges of E. None if degenerate-empty."""
    m, n = len(P), len(E)
    if m == 0 or n == 0:
        return None
    E0 = E
    E1 = np.roll(E, -1, axis=0)
    dot01 = np.einsum("ij,ij->i", E0, E1)
    cross01 = np.cross(E0, E1)
    nlen = np.linalg.norm(cross01, axis=1)
    nnorm = np.where(nlen > 1e-10, nlen, 1.0)
    nh = cross01 / nnorm[:, None]
    best = math.inf
    for s in range(0, m, CHUNK):
        d = _sweep_chunk(P[s:s+CHUNK], E0, E1, dot01, cross01, nlen, nh)
        if d < best:
            best = d
        if best <= 0.0:
            return 0.0
    return best

def edge_to_edge_km(VA, VB):
    """Vectorized mirror of EdgeToEdgeDistanceKm + PointToArcDistance + OnArc."""
    da = _sweep(VA, VB)
    db = _sweep(VB, VA)
    vals = [v for v in (da, db) if v is not None]
    if not vals:
        return math.inf
    return min(vals)

def main():
    src = sys.argv[1] if len(sys.argv) > 1 else "Cached Data/PolygonCache.csv"
    dst = sys.argv[2] if len(sys.argv) > 2 else "Cached Data/BorderDistanceCache.csv"
    t0 = time.time()
    regions = load(src)
    names = sorted(regions)
    n = len(names)
    print(f"Loaded {n} regions, {sum(len(v) for v in regions.values())} vertices", flush=True)

    vecs = {nm: unit_vecs(regions[nm]) for nm in names}
    sizes = np.array([len(regions[nm]) for nm in names])

    out = open(dst, "w", encoding="utf-8")
    total = n * (n - 1) // 2
    count = 0
    for i in range(n):
        a = names[i]
        VA = vecs[a]
        for j in range(i + 1, n):
            b = names[j]
            d = edge_to_edge_km(VA, vecs[b])
            ka, kb = (a, b) if a <= b else (b, a)
            out.write(f"{ka},{kb},{d:.6f}\n")
            count += 1
        if (i + 1) % 10 == 0:
            out.flush()
            el = time.time() - t0
            done = (i + 1) * (2 * n - i - 1) / 2.0
            eta = el / done * (total - done)
            print(f"  {i+1}/{n} regions | {int(done)}/{total} pairs | {el:.0f}s el, ~{eta:.0f}s ETA", flush=True)
    out.close()
    print(f"Wrote {count} pairs to {dst} in {time.time()-t0:.0f}s")

if __name__ == "__main__":
    main()
