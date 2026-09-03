# Creeping Borders - Localization Strings

## Overview
This file contains the localization strings required for the Creeping Borders mod to display the discontiguity malus in the Nation UI cohesion breakdown.

## Installation Instructions

The `UINation.en` file should be placed in your mod's localization directory following Terra Invicta's localization structure:
```
CreepingBorders/
  Localization/
	en/
	  UINation.en
```

## String Reference

### New String: Discontiguity Malus
```
UI.Nation.FromDiscontiguity={0} from territorial discontiguity (population in non-contiguous regions without island status)
```

This string is displayed in the Cohesion Rest State breakdown when:
1. `EnableDiscontiguityMalus` setting is enabled
2. The nation has population in regions that are neither contiguous with the capital nor valid islands
3. The calculated discontiguity impact is non-zero

### Related Strings (for reference)
These are the existing cohesion impact strings that the discontiguity malus integrates with:
```
UI.Nation.FromInequality={0} from inequality (mitigated by education below 10)
UI.Nation.FromLowPCGDP={0} from lost per capita GDP in last 10 years, multiplied by inequality
UI.Nation.FromPopulation={0} from population
UI.Nation.FromRegions={0} from geographic population distribution
UI.Nation.FromRivals={0} from near-peer or stronger rivalries
UI.Nation.FromWars={0} from wars
UI.Nation.FromIdeology={0} from elite-public ideology differences
UI.Nation.FromInternalDifferences={0} from public opinion distribution
UI.Nation.FromAutocracy={0} from autocracy, reduced by unrest
UI.Nation.FromAnocracy={0} from anocracy
UI.Nation.FromDemocracy={0} from democracy
UI.Nation.FromHostileClaims_Cohesion={0} from our regions with Hostile claims, mitigated by low government score
```

## Display Format

In the Nation Info UI, the discontiguity malus appears in the "Cohesion rest state breakdown" section after the geographic population distribution (regions) impact:

```
Cohesion rest state breakdown:
Base value: 16.00
[other impacts...]
+X.XX from geographic population distribution
-X.XX from territorial discontiguity (population in non-contiguous regions without island status)
[remaining impacts...]
```

## Notes

- The string uses the Terra Invicta localization format with `{0}` placeholder for the numeric value
- The value is automatically formatted as "N2" (2 decimal places) by the patch
- The discontiguity malus appears in the same breakdown as other cohesion factors
- The localization key follows the vanilla naming convention: `UI.Nation.From[FactorName]`

## Customization

To customize this string for other languages, follow the same format and translate to the desired language. For example, for French:

```
UI.Nation.FromDiscontiguity={0} de la non-contiguïté territoriale (population dans les régions non contiguës sans statut d'île)
```

Place language-specific versions in appropriately named files:
- English: `Localization/en/UINation.en`
- French: `Localization/fr/UINation.fr`
- Spanish: `Localization/es/UINation.es`
- etc.
