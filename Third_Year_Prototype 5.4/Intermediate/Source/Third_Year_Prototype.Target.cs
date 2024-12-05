using UnrealBuildTool;

public class Third_Year_PrototypeTarget : TargetRules
{
	public Third_Year_PrototypeTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Third_Year_Prototype");
	}
}
