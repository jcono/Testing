param($target = "default")
$root = Split-Path -Parent $MyInvocation.MyCommand.Path
$scriptDir = "$root\build\scripts"
Import-Module $root\packages\psake.4.2.0.1\tools\psake.psm1 -Force

Try	{
		Push-Location
		Invoke-Psake $scriptDir\build.ps1 $target
	}
	Finally{
		Pop-Location
	}