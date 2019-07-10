---
title: Financial - Material
layout: page
show_sidebar: false
menubar: faq-nav
ref: financial-material
permalink: /financial-material
lang: en
---

## Calculation method
The value of materials is preferably imported from commonly used commodity prices. The historical price development of materials is firstly corrected with the inflation of the year that the price development took place at the inflation rate of the country of the currency of the commodity price value. Besides the currency exchange is also took into consideration per year in the past. The historical data that is generated this way is real value data. With this real time historical data, a linear trendline is generated using a regression analysis with the least-squares method.

## Correction factors
After this, the material values are corrected with demolition costs, recycling costs, logistic costs and a correction for the size of the material batch. The demolition costs are corrected each year with the BDB-index which represent the inflation in building costs. The average of price development of the last 18 years represents the default value which can be adapted. The recycling costs are independent for each material and calculated based on desk research and interviews. For transportation costs, a 150 km transport is taken as assumption for logistic costs. Two material groups have a different rate for this costs, namely Stone (20km) and Wood (40km).

## References
* LME (London Metal Exchange)
* Quandl
* www.vraagenaanbod.nl
* RVO
* BLS Beta Labs

## What is the influence of inflation, the BDB index and the discount rate on the calculation?
The influence is easily checkable in the sensitivity analysis on the detail pages. Values can be adapted. As a default value, the average inflation and average BDB index of the past 18 years is given. The Discount rate is built up consisting 0,7% of the euribor, 2% is representing the risk and 0,3% represents the premium for the financer. 