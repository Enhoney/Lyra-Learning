// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class LyraLearningEditor : ModuleRules
{
	public LyraLearningEditor(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(
			new string[] {
				"LyraLearningEditor"
		});

		PrivateIncludePaths.AddRange(
			new string[] {
				
			});
		
	
		PublicDependencyModuleNames.AddRange(
			new string[] { 
				"Core",
				"CoreUObject",
				"Engine", 
				"LyraLearningGame",
			});

		PrivateDependencyModuleNames.AddRange(
		new string[] { 
			"InputCore",
			"Slate",
			"SlateCore"
		});
	}
}
