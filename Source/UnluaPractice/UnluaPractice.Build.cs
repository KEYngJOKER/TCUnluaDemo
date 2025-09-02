// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UnluaPractice : ModuleRules
{
	public UnluaPractice(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"UnluaPractice",
			"UnluaPractice/Variant_Platforming",
			"UnluaPractice/Variant_Platforming/Animation",
			"UnluaPractice/Variant_Combat",
			"UnluaPractice/Variant_Combat/AI",
			"UnluaPractice/Variant_Combat/Animation",
			"UnluaPractice/Variant_Combat/Gameplay",
			"UnluaPractice/Variant_Combat/Interfaces",
			"UnluaPractice/Variant_Combat/UI",
			"UnluaPractice/Variant_SideScrolling",
			"UnluaPractice/Variant_SideScrolling/AI",
			"UnluaPractice/Variant_SideScrolling/Gameplay",
			"UnluaPractice/Variant_SideScrolling/Interfaces",
			"UnluaPractice/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
