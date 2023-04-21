using static ThisAssembly.Git;
Console.WriteLine($"{SemVer.Major}.{SemVer.Minor}.{SemVer.Patch}{SemVer.DashLabel}+{Branch}.${Commit}");
