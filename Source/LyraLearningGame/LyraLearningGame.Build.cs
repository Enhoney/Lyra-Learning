// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class LyraLearningGame : ModuleRules
{
	public LyraLearningGame(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(
			new string[]{
				"LyraLearningGame",
				
			});
	
		PublicDependencyModuleNames.AddRange(new string[] { 
		"Core", 
		"CoreUObject", 
		"Engine",
		"InputCore", 
		"EnhancedInput",
		
		});

		PrivateDependencyModuleNames.AddRange(new string[] {  });

	}
}
