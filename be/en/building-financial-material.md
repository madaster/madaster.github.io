---
title: Financial - Material
ref: building-financial-material
---

## Computation method
The material value is preferably imported from commodity prices of common commodity exchanges. The historical price increase of materials is first corrected with the inflation of the year in question and the corresponding exchange rate in case the commodity is in a different currency. The data points in the history of commodity prices with this deduction is the basis for a linear trend line determined on the basis of a regression analysis, i.e. the least-squares method.


### Correction factors
Subsequently, the material values were corrected for demolition costs, processing costs, a correction for the size of the raw material flow and transport costs per kg. Demolition costs are indexed with the average BDB index of the last 18 years. Processing and processing costs are material-dependent and determined on the basis of interviews and desk research. For transport costs, a distance to the processor of 150 km per freight transport has been assumed for all materials except stony materials (20 km) and wood (40 km).


### Sources
- LME (London Metal Exchange)
- Quandl
- www.vraagenaanbod.nl
- RVO
- BLS Beta Labs

### What influence do inflation, BDB Index (construction costs index) and the discount rate have on my calculation?
The influence of these can be tested in the sensitivity analysis on the detail pages. Here the inflation, BDB index and the discount rate can be adjusted. The values for inflation and the BDB-index are standard on the average of the last 18 years. For the discount rate, the 10-year government interest rate (0.7%) is taken with a number of risk (2%) and profit (0.3%) added.
