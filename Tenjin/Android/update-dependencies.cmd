@echo off
del /q %~dp0NativeDependencies\*
call "%ProgramFiles%\Gradle\bin\gradle.bat" update
:: Keep only Tenjin's own AAR: its dependencies come from NuGet packages (see the csproj)
for %%f in (%~dp0NativeDependencies\*) do (
    echo %%~nxf | findstr /b /c:"android-sdk-" >nul || del "%%f"
)
for %%f in (%~dp0NativeDependencies\android-sdk-*.aar) do ren "%%f" "tenjin-%%~nxf"
