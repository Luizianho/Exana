// CodeSpartan

using UnrealBuildTool;
using System.Collections.Generic;

[SupportedPlatforms(UnrealPlatformClass.Server)]
public class ExanaServerTarget : TargetRules
{ 
	public ExanaServerTarget(TargetInfo Target) : base(Target)
    {        
        Type = TargetType.Server;
        DefaultBuildSettings = BuildSettingsVersion.V2;
        ExtraModuleNames.Add("Exana");
        bUseLoggingInShipping = true;
    }
}