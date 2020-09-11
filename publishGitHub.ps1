$source =  "C:\Repos\Docs\madaster.github.io"
$destination = "C:\Repos\Docs\madaster-t.github.io"

$exclude = ".git","CNAME","publishGitHub.ps1"
$items = Get-ChildItem -Path $source | Where-Object  {$exclude -notcontains $_.Name}


foreach ($f in $items){ 
    Write-Host "This items will be copied: $f"
    Copy-Item -Path $source\$f -Destination $destination\$f -Recurse -Force
} 