# HotChai.Bindings

C# bindings for native iOS and Android SDKs

## Overview

*tldr; These bindings enable you to stay current with the very latest native library updates.*

The bindings are distributed as code separate from the native libraries they bind, so the native libraries can be updated independent of the bindings using native tooling.

This works because native library updates don't often include breaking changes for public API's, so the bindings don't need to change with every library release.

This makes it possible to stay current with native library updates, despite the usual delays (or abandonment) of typical bindings projects.

## Current

*tldr; These bindings work for my purposes but may not work for yours.*

The bindings code generation tools typically output code that requires manual editing, which is error-prone and makes it extra fun to updating the bindings for a new library release. I've fixed the bindings methods I use, but you may encounter issues with binding methods I haven't tested.

The bindings code generation tools also try to mangle native method calls to make them follow .NET conventions, for example, by changing get/set accessors into C# properties. Given this mangling, it may be challenging to use the docs for the native library, but you can usually find what you're looking for by poking around with Intellisense.

Maybe someday we'll be able to generate straightforward .NET bindings for native libraries without all the error-prone mangling and inconsistencies with the library documentation. In the meantime, this is what we have to work with. 

## Future

*tldr; Some magic to make it easier to consume these bindings.*

The current bindings are fairly tedious to consume initially and require manual editing of csproj files. In the future I may create NuGet packages that install bindings as code (but explicitly never as a dll) and, if possible, perhaps include the appropriate native references. However, native libraries will explicitly never be included in a NuGet package since the entire point of this project is to allow the native libraries to be updated independent of the bindings.

Microsoft seems bent on removing support for the shared projects on which this project depends. So far they can still be consumed even if there are no templates for creating new shared projects and they aren't too difficult to create in a text editor, but there may be a need to find some alternative for sharing code across projects.

## iOS Bindings

iOS libraries are downloaded via CocoaPods (https://cocoapods.org) and bindings are generated with Sharpie (http://xmn.io/sharpie-docs). Binding project files are located in the src folder and the generated bindings (from the obj build output folder) are copied to the Bindings folder.

To use the bindings in a project, add a reference to the shared project in the Bindings folder and add the CocoaPods dependencies from the src folder.

.NET 8 csproj files also need the following to bind Swift libraries:

```
	<Target Name="LinkWithSwift" DependsOnTargets="_ParseBundlerArguments;_DetectSdkLocations" BeforeTargets="_LinkNativeExecutable">
		<PropertyGroup>
			<_SwiftPlatform Condition="$(RuntimeIdentifier.StartsWith('iossimulator-'))">iphonesimulator</_SwiftPlatform>
			<_SwiftPlatform Condition="$(RuntimeIdentifier.StartsWith('ios-'))">iphoneos</_SwiftPlatform>
		</PropertyGroup>
		<ItemGroup>
			<_CustomLinkFlags Include="-L" />
			<_CustomLinkFlags Include="/usr/lib/swift" />
			<_CustomLinkFlags Include="-L" />
			<_CustomLinkFlags Include="$(_SdkDevPath)/Toolchains/XcodeDefault.xctoolchain/usr/lib/swift/$(_SwiftPlatform)" />
			<_CustomLinkFlags Include="-Wl,-rpath" />
			<_CustomLinkFlags Include="-Wl,/usr/lib/swift" />
		</ItemGroup>
	</Target>
```

## Android Bindings

Android libraries are downloaded via Gradle (https://gradle.org) and bindings are generated with the csproj `<AndroidLibrary Bind="true" />` parameter. The resulting bindings (from the obj build output folder) are copied to the Bindings folder.

To use the bindings in a project, add a reference to the shared project in the Bindings folder and add the Gradle dependencies from the src folder.

## Contributing

*tldr; Yes, please.*

Maintaining bindings for all the libraries necessary to create a C# free-to-play game is a monumental task and I tried every option I could to avoid it. But here we are. Perhaps we can pool our resources and mutually benefit.
