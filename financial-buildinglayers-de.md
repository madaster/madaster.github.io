---
title: Finanzen - Gebäudeschicht
layout: page
show_sidebar: false
menubar: faq-nav
ref: financial-buildinglayers
permalink: /financial-buildinglayers-de
lang: de
---

## Calculation method
The different layers have a functional lifecycle which ends in the expiration year cash flow. This value is default given by Madaster but can manually be adjusted in the general tab. In the Layers of Brand tab, the value of materials will be determined based on the end of life date. The value of a material at that date is calculated back to today with the net present value (NPV) calculation using the discount rate. The sum of the NPV’s represents the building value expressed in material value. 

## Trend line determination
According the trendline of material value, the expected value in different years in the future is determined. The material value is imported preferably from common commodity prices. The price mutation is firstly corrected with inflation in the year of mutation. After that, prices are translated into euro’s according to the currency exchange rate of the specific year. The points in the trendline are analyzed using a regression analysis, namely: the least-squares method. 

## Correction factors
After this, the material values are corrected with demolition costs, recycling costs, logistic costs and a correction for the size of the material batch. The demolition costs are corrected each year with the BDB-index which represent the inflation in building costs. The average of price development of the last 18 years represents the default value which can be adapted. The recycling costs are independent for each material and calculated based on desk research and interviews. For transportation costs, a 150 km transport is taken as assumption for logistic costs. Two material groups have a different rate for this costs, namely Stone (20km) and Wood (40km).

## References
* Brand, S. (1994). How Buildings Learn
* LME (London Metal Exchange)
* Quandl
* www.vraagenaanbod.nl
* RVO
* BLS Beta Labs

## What is the influence of inflation, the BDB index and the discount rate on the calculation?
The influence is easily checkable in the sensitivity analysis on the detail pages. Values can be adapted. As a default value, the average inflation and average BDB index of the past 18 years is given. The Discount rate is built up consisting 0,7% of the euribor, 2% is representing the risk and 0,3% represents the premium for the financer. 