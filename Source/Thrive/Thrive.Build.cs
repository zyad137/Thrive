// Copyright (C) 2013-2017  Revolutionary Games

using UnrealBuildTool;

public class Thrive : ModuleRules
{
	public Thrive(TargetInfo Target)
	{
		PublicDependencyModuleNames.AddRange(new string[] {
                "Core",
                "CoreUObject",
                "Engine",
                "InputCore",

                // Victory requires these.
                // We would probably require Slate and UMG things anyway 
                "VictoryBPLibrary",
                "UMG",
                "Slate",
                "SlateCore",
                "ImageWrapper",
            });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });
		
		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}