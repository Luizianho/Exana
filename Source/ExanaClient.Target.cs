// CodeSpartan

using UnrealBuildTool;
using System.Collections.Generic;

[SupportedPlatforms(UnrealPlatformClass.Desktop)]
public class ExanaClientTarget : TargetRules
{ 
	public ExanaClientTarget(TargetInfo Target) : base(Target)
    {        
        Type = TargetType.Client;
        DefaultBuildSettings = BuildSettingsVersion.V2;
        ExtraModuleNames.Add("Exana");
        bUseLoggingInShipping = true;
    }
}