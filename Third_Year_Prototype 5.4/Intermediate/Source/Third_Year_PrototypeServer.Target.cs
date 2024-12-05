using UnrealBuildTool;

public class Third_Year_PrototypeServerTarget : TargetRules
{
	public Third_Year_PrototypeServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Third_Year_Prototype");
	}
}
