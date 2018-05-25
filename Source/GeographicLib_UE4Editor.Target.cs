// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class GeographicLib_UE4EditorTarget : TargetRules
{
	public GeographicLib_UE4EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "GeographicLib_UE4" } );
	}
}
