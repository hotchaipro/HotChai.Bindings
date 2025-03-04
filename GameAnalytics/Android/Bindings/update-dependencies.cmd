@echo off
del /q %~dp0NativeDependencies\*
call "%ProgramFiles%\Gradle\bin\gradle.bat" update
:: Remove dependencies already included in NuGet packages
::   com.google.android.gms:play-services-appset
::   com.google.android.gms:play-services-instantapps
del %~dp0NativeDependencies\annotation-*.jar
del %~dp0NativeDependencies\asynclayoutinflater-*.aar
del %~dp0NativeDependencies\collection-*.jar
del %~dp0NativeDependencies\coordinatorlayout-*.aar
del %~dp0NativeDependencies\core-common-*.jar
del %~dp0NativeDependencies\core-runtime-*.aar
del %~dp0NativeDependencies\core-*.aar
del %~dp0NativeDependencies\cursoradapter-*.aar
del %~dp0NativeDependencies\customview-*.aar
del %~dp0NativeDependencies\documentfile-*.aar
del %~dp0NativeDependencies\drawerlayout-*.aar
del %~dp0NativeDependencies\fragment-*.aar
del %~dp0NativeDependencies\instantapps-*.aar
del %~dp0NativeDependencies\interpolator-*.aar
del %~dp0NativeDependencies\legacy-support-core-ui-*.aar
del %~dp0NativeDependencies\legacy-support-core-utils-*.aar
del %~dp0NativeDependencies\lifecycle-common-*.jar
del %~dp0NativeDependencies\lifecycle-livedata-core-*.aar
del %~dp0NativeDependencies\lifecycle-livedata-*.aar
del %~dp0NativeDependencies\lifecycle-runtime-*.aar
del %~dp0NativeDependencies\lifecycle-viewmodel-*.aar
del %~dp0NativeDependencies\loader-*.aar
del %~dp0NativeDependencies\localbroadcastmanager-*.aar
del %~dp0NativeDependencies\play-services-appset-*.aar
del %~dp0NativeDependencies\play-services-base-*.aar
del %~dp0NativeDependencies\play-services-basement-*.aar
del %~dp0NativeDependencies\play-services-tasks-*.aar
del %~dp0NativeDependencies\print-*.aar
del %~dp0NativeDependencies\slidingpanelayout-*.aar
del %~dp0NativeDependencies\swiperefreshlayout-*.aar
del %~dp0NativeDependencies\versionedparcelable-*.aar
del %~dp0NativeDependencies\viewpager-*.aar
