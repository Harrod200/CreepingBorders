# Contiguity Model — British Isles (desk check, 2026-10-07)

Purpose: validate the PolygonalRegionConnectivityManager fix (Incident 4/5) against a
real multi-region archipelago before the in-game load test.

## Regions (display name -> ID, per the Incident 4 name->ID rule)

| Display   | ID                    | Capital of |
|-----------|-----------------------|------------|
| London    | 2003_England          | UK         |
| Birmingham| 2003_EnglishMidlands  |            |
| Glasgow   | 2003_Scotland         |            |
| Belfast   | 2003_NorthernIreland  |            |

X = 300 km: Full <= 300 km, Partial <= 900 km.

## Cached polygon border distances (BorderDistanceCache.csv)

| Pair                  | km      |
|-----------------------|---------|
| England–Midlands      | 0.0     |
| England–Wales         | 0.0     |
| Midlands–Wales        | 0.0     |
| Midlands–Scotland     | 0.0     |
| England–Scotland      | 318.27  |
| Scotland–N. Ireland   | 22.00   |
| England–N. Ireland    | 325.43  |
| Midlands–N. Ireland   | 52.42   |
| Wales–N. Ireland      | 116.27  |

England and Scotland do NOT share a border — the Midlands belt separates them
(owner-confirmed; the 318 km England–Scotland value is real, not an artifact).

## Trace (capital = London)

Pass A (vanilla adjacency, inherit level):
  London -> Birmingham, Wales : inherit Capital
  Birmingham -> Wales, Glasgow: inherit Capital

Pass B (polygon distance from any Partial+ region):
  London  -> Belfast  325.4 km -> Partial (0.4 km over the Full gate)
  Glasgow -> Belfast   22.0 km -> Full

## Result

| Region     | Level   | Basis                                   |
|------------|---------|-----------------------------------------|
| London     | Capital | seed                                     |
| Birmingham | Full    | adjacency from London                    |
| Wales      | Full    | adjacency from London/Birmingham         |
| Glasgow    | Full    | adjacency from Birmingham                |
| Belfast    | Full    | bridged: 22.0 km from Full Glasgow       |

Belfast has no vanilla adjacency (Ireland island is isolated) — same pattern as
Ambon (2003_MoluccasandSulawesi). Fixpoint re-enqueue promotes Belfast Partial->Full
after Glasgow's bridge grants it; ordering-independent.

Desktop sanity: Glasgow-Belfast ~160 km city-to-city; 22 km is coast-to-coast
(Mull of Kintyre <-> Antrim) as intended.
