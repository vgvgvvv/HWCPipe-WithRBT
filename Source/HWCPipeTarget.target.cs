using ReBuildTool.ToolChain;

public class HWCPipeTarget : CppTargetRule
{
    public HWCPipeTarget()
    {
        UsedModules.Add("HWCPipeModule");
    }
} 
