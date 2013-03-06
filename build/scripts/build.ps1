$msbuild = "c:\Windows\Microsoft.NET\Framework64\v4.0.30319\msbuild.exe"
$RootDir = "c:\Work\Apparel21\ExampleProject\Testing"
$NUnitConsole = "$RootDir\packages\NUnit.Runners.2.6.2\tools\nunit-console.exe"
Task default -depends Test

Task Test -depends Compile {
	$TestCommand = "$NUnitConsole $RootDir\Testing.Examples\bin\Release\Testing.Examples.dll"
	iex $TestCommand
}

Task Compile {
	$BuildCommand = "$msbuild /p:Configuration=Release $RootDir\Testing.sln"
	iex $BuildCommand
}