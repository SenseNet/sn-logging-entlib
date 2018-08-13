$srcPath = [System.IO.Path]::GetFullPath(($PSScriptRoot + '\..\..\src'))

# delete existing packages
Remove-Item $PSScriptRoot\*.nupkg

nuget pack $srcPath\EntlibLogger\SenseNet.EntlibLogger.nuspec -properties Configuration=Release -OutputDirectory $PSScriptRoot