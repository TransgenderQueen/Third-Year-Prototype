using UnrealBuildTool;

public class Third_Year_PrototypeClientTarget : TargetRules
{
	public Third_Year_PrototypeClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Third_Year_Prototype");
	}
}
