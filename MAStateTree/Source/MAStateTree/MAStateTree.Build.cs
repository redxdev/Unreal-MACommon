﻿// Copyright (c) MissiveArts LLC

using System.IO;
using UnrealBuildTool;

public class MAStateTree : ModuleRules
{
	public MAStateTree(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"CoreUObject",
				"Engine",
				"AIModule",
				"NavigationSystem",
				"StateTreeModule",
				"GameplayStateTreeModule",
				"GameplayTasks",
				"GameplayTags",
				"StructUtils",
			});

		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"MAGameplay",
			});

		if (Target.bBuildEditor)
		{
			PrivateDependencyModuleNames.Add("StateTreeEditorModule");
		}
	}
}