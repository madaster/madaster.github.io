# madaster.github.io
Documentation of the Madaster Platform

## Updating the spectacle api-docs manually
Run `update-api-docs.ps1`, which runs the following commands:
```
Invoke-WebRequest https://api.madaster.com/swagger/v2.0/swagger.json -OutFile swagger.json
spectacle -t api-docs -l assets/images/madaster-logo.svg swagger.json
```
## Run locally
  
  bundle install
  bundle exec jekyll serve