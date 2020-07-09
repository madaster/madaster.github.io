# madaster.github.io
Documentation of the Madaster Platform

## Updating the spectacle api-docs manually
Run `update-api-docs.ps1`, which runs the following commands:
```
Invoke-WebRequest https://api.madaster.com/api/v2.3/swagger.json -OutFile swagger.json
spectacle -t api-docs -l assets/images/madaster-logo.svg swagger.json
```
