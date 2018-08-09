# Madaster API Enumerations
The **Madaster API** uses enumerations throughout the entire range of functions. An enumeration allows for a property of an entity to have a fixed set of possible values, each of which have a numeric value for data storage and a textual representation or label to clarify what the value means.

The API always returns the numeric value of the enumeration, which will not mean anything to the human reader. To find out what the value you received means, please check below for all possible options.

When using an enumeration as part of your request, you can supply either the numeric value or the textual representation.

## Enumerations
### BuildingFileStatuses

Label | Value
--- | ---
Error | 0
Uploaded | 1
Refined | 2
Mapped | 3
Refining | 4
Mapping | 5
Creating | 6
Importing | 7
Imported | 8
UnknownImportFile | 99

### BuildingFileType
Label | Value
--- | ---
Source | 0,
Information | 1,
PassportPdf | 1000,
PassportExcel | 1001

### BuildingRequestFileType
Label | Value
--- | ---
Source | 0,
Information | 1

### PortfolioFileStatuses
Uploaded | 1,
Creating | 6

### PortfolioFileType
Information | 1,
PassportPdf | 1000

### SubscriptionType
Label | Value
--- | ---
Small | 1,
Medium | 2,
Large | 3,
XLarge | 4,
Custom | 5,
Private | 6

### SalutationType
Label | Value
--- | ---
Sir | 1,
Madam | 2

### PriceUnit
Label | Value
--- | ---
mt | 0
kg | 1
m3 | 2
lb | 3
toz | 4
index | 5

### PartnerType
Label | Value
--- | ---
Solution | 1,
Data | 2,
Service | 3

### InflationType
Label | Value
--- | ---
Yearly | 0,
Monthly | 1

### FinanialDataSetType
Label | Value
--- | ---
Price | 0,
ExchangeRate | 1,
Inflation | 2

### FinancialImportType
Label | Value
--- | ---
None | 0,
Manual | 10,
Automatic | 20,
AutomaticIndex | 30

### FileType
Label | Value
--- | ---
Source | 0,
Information | 1,
PassportPdf | 1000,
PassportExcel | 1001

### FileStatuses
Label | Value
--- | ---
Error | 0,
Uploaded | 1,
Refined | 2,
Mapped | 3,
Refining | 4,
Mapping | 5,
Creating | 6,
Importing | 7,
Imported | 8,
UnknownImportFile | 99

### PriceItemCurrency
Label | Value
--- | ---
EUR | 0
USD | 1
GLD | 2
GBP | 3
CN | 4

### ClassificationType
Label | Value
--- | ---
SourceFile | 1,
InformationFile | 2,
Passport | 3,
Personal | 4

### BuildingLocationTypes
Label | Value
--- | ---
BuildingTotals | 0,
Site | 1,
Structure | 2,
Skin | 3,
Services | 4,
SpacePlan | 5,
Stuff | 6,
Unknown | 7

### UserType
Label | Value
--- | ---
User | 0,
Token | 1

### RegistrationType
Label | Value
--- | ---
Unknown | 0,
Private | 1,
Business | 2,
Invited | 3,
InviteRequested | 4

### PermissionLevelDefinedAt
Label | Value
--- | ---
Account | 1,
Portfolio | 2,
Building | 3

### PermissionLevel
Label | Value
--- | ---
Administrator | 90,
Write | 70,
Read | 50,
None | 0

### ExpirationTime
Label | Value
--- | ---
OneYear | 1,
TwoYears | 2,
Infinite | 100

### ElementType
Label | Value
--- | ---
Material | 10,
VolumeProduct | 20,
QuantityProduct | 30,
AreaProduct | 40,
LengthProduct | 50

### ElementPropertyType
Label | Value
--- | ---
Other | 0,
Guid | 10,
Name | 20,
Supplier | 21,
SpecificWeight | 30,
Url | 40,
Ean | 50,
Value | 60,
Description | 70,
Percentage | 80,
Calculated | 81,
Boolean | 90,
Size | 100

### ElementMatchType
Label | Value
--- | ---
None | 0,
Name | 10,
Ean | 20

### ElementExtensionType
Label | Value
--- | ---
Other | 0,
System | 10,
Calculated | 11,
ExternalDatabase | 20,
Supplier | 30

### ElementDimensionType
Label | Value
--- | ---
Length | 0,
Width | 1,
Height | 2,
Depth | 3,
Diameter | 4,
Radius | 5,
Thickness | 6,
Area | 7,
Volume | 8

### ChildRelationType
Label | Value
--- | ---
Fixed | 10,
Volume | 30,
Area | 40,
Length | 50,
Quantity | 60
