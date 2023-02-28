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

# Create new dotnet projects
Use `dotnet new` to create new project from templates.
```
dotnet new webapi -o src/Api -n DuongTruong.CPVM.Api
dotnet sln add src/Api
```
Both project file and `Directory.Packages.props` must be update, so that project will be restored and builded. Remove package references in project file, and then add them. `dotnet` cli work normally wil project opt-in CPVM. `PackageVersion` will be added in `Directory.Packages.props` to determine the version of package. Remember to target version if it's necessary.
```
cd src/Api
dotnet list package

dotnet remove package Microsoft.AspNetCore.OpenApi
dotnet remove package Swashbuckle.AspNetCore

dotnet add package Microsoft.AspNetCore.OpenApi
dotnet add package Swashbuckle.AspNetCore
```

## Enable lock files
Set `RestorePackagesWithLockFile` to true in `Directory.Packages.props` to enable package lock files globally. `packages.lock.json` will be auto-generated. Restore in lock mode need lock files to advoid unwanted upgrade from floating versions of packages.
