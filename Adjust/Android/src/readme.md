build.gradle:

dependencies
{
    implementation 'com.android.installreferrer:installreferrer:2.2'
    implementation 'com.adjust.sdk:adjust-android:4.38.5'
}

csproj:

  <!-- Adjust -->
  <ItemGroup>
    <AndroidLibrary Include="NativeDependencies\installreferrer-2.2.aar" Bind="false">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </AndroidLibrary>
    <AndroidLibrary Include="NativeDependencies\adjust-android-4.38.5.aar" Bind="false">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </AndroidLibrary>
  </ItemGroup>
