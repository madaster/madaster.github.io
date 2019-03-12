Invoke-WebRequest https://api.madaster.com/swagger/v2.0/swagger.json -OutFile swagger.json
spectacle -t api-docs -l assets/images/madaster-logo.svg swagger.json