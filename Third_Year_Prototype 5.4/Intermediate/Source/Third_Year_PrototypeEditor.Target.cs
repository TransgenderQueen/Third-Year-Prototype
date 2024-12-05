using UnrealBuildTool;

public class Third_Year_PrototypeEditorTarget : TargetRules
{
	public Third_Year_PrototypeEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Third_Year_Prototype");
	}
}
