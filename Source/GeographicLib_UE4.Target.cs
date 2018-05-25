// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class GeographicLib_UE4Target : TargetRules
{
	public GeographicLib_UE4Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "GeographicLib_UE4" } );
	}
}
