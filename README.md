# DotnetCPVM
Enable Nuget Central Package Version Management (CPVM). This approach differs from MSBuild SDK Central Package Versions (CPV).

# Target Framework
.NET 7.0

# Enable CPVM
Create new `Directory.Packages.props` file as bellow to enable CPVM:
`
<Project>
  <PropertyGroup>
    <ManagePackageVersionsCentrally>true</ManagePackageVersionsCentrally>
  </PropertyGroup>
</Project>
`
P/s: As a trick, use `dotnet new buildprops` to create MSBuild Directory.Build.props file. Then rename its to `Directory.Packages.props` to start from scratch.
