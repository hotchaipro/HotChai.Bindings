build.gradle:

dependencies
{
    implementation 'com.facebook.android:facebook-android-sdk:latest.release'
}

csproj:

  <!-- Facebook -->
  <ItemGroup>
    <AndroidLibrary Include="NativeDependencies\facebook-core-17.0.0.aar" Bind="false">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </AndroidLibrary>
    <AndroidLibrary Include="NativeDependencies\facebook-common-17.0.0.aar" Bind="false">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </AndroidLibrary>
    <AndroidLibrary Include="NativeDependencies\cardview-1.0.0.aar" Bind="false">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </AndroidLibrary>
  </ItemGroup>
