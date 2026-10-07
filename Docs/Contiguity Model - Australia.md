# Contiguity Model — Australia (Indonesia expansion desk-check)

X = 300 km (Full gate), 3X = 900 km (Partial gate). All distances from BorderDistanceCache.csv.

## Region name → ID mapping
| display | ID |
|---|---|
| Port Moresby | `2003_PortMorseby` |
| Brisbane | `2003_Brisbane` |
| Darwin | `2003_Darwin` |
| Sydney | `2003_Sydney` |
| Adelaide | `2003_Adelaide` |
| Melbourne | `2003_Melbourne` |
| Perth | `2003_Westralia` |

Note the typo in vanilla/cache IDs: `PortMorseby` (one 's').

## Chain: capital (Sumatra/Jakarta) → Port Moresby → Full

| hop | km | class |
|---|---|---|
| Sumatra ↔ Borneo | 209.29 | Full |
| Borneo ↔ Sulawesi | 115.61 | Full |
| Sulawesi ↔ Lesser Sundas | 73.71 | Full |
| Lesser Sundas ↔ MoluccasandSulawesi | 74.60 | Full |
| MoluccasandSulawesi ↔ New Guinea | 33.58 | Full |
| New Guinea ↔ Port Moresby | 0.00 | vanilla adjacency (same island) |

Port Moresby: Full via Pass A from Biak. Requires the Incident 6 fix (dead
PolygonalRegionConnectivityManager) — before it, Ambon/Biak were Partial and
this chain never assembles.

## Brisbane
Brisbane ↔ Port Moresby = 153.73 km < 300 → **Full** by distance bridging from
a Full region. No ownership-agnostic land route to the Indonesian capital
(Torres Strait is not a land adjacency), so the Incident 6d cap does not apply.

## Adjacent claims from Brisbane (Pass A, distance 0.0 = touching polygons)
Darwin 0.0, Sydney 0.0, Adelaide 0.0 → inherit **Full** from Brisbane.
Melbourne 546.06 → Partial (Pass B only). Westralia 896.42 → Partial (under 900 gate).

Adelaide ↔ Westralia = 0.0 → once Adelaide is annexed and Full, Westralia becomes
Full via Pass A. Perth falls last.

## Incident 6d cap in the expansion corridor
While Darwin/Sydney/Adelaide are claimed but the interior between them and
Brisbane is foreign, they are physically land-reachable from the capital
through non-Indonesian ground → Pass B Full grants are capped at Partial →
not annexable until the intervening territory is Indonesian. Each annexation
unlocks the next ring; only owned-corridor or open-water bridging stays Full.

## Westfall
Perth cannot be bridged from the west (nearest partner Denpasar 457.4 km, itself
only Partial). It becomes Full only after Adelaide (east-coast cascade).
