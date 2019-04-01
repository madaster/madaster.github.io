[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
Invoke-WebRequest https://api.madaster.com/swagger/v2.1/swagger.json -OutFile swagger.json
spectacle -t api-docs -l assets/images/madaster-logo.svg swagger.json