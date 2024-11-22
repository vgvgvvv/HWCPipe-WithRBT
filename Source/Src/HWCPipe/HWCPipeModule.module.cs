using ReBuildTool.ToolChain;
using System.IO;
using ReBuildTool.Service.CompileService;

public class HWCPipeModule : CppModuleRule
{
    public HWCPipeModule()
    {
       
    }

    public override void Setup(ICppBuildContext buildContext)
    {
        base.Setup(buildContext);
        TargetBuildType = BuildType.DynamicLibrary;
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "hwcpipe/include"));
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "hwcpipe/src"));
        SourceDirectories.Add(Path.Combine(ModuleDirectory, "hwcpipe/src"));
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "backend/device/include"));
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "backend/device/src"));
        SourceDirectories.Add(Path.Combine(ModuleDirectory, "backend/device/src"));
    }
}
