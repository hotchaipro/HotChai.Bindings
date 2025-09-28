@echo off
del /q %~dp0NativeDependencies\* 2>nul
call "%ProgramFiles%\Gradle\bin\gradle.bat" update
del /q %~dp0NativeDependencies\annotation-jvm-*.jar
del /q %~dp0NativeDependencies\annotations-*.jar
del /q %~dp0NativeDependencies\collection-jvm-*.jar
del /q %~dp0NativeDependencies\collection-ktx-*.jar
del /q %~dp0NativeDependencies\kotlin-stdlib-*.jar
del /q %~dp0NativeDependencies\kotlinx-coroutines-core-jvm-*.jar
del /q %~dp0NativeDependencies\okio-*.jar
