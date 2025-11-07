// Copyright Epic Games, Inc. All Rights Reserved.

#include "LyraLearningEditor.h"
#include "Modules/ModuleManager.h"

/**
 * FLyraLearningEditorModule
 */
class FLyraLearningEditorModule : public FDefaultGameModuleImpl
{
	virtual void StartupModule() override
	{
	}

	virtual void ShutdownModule() override
	{
	}
};

IMPLEMENT_MODULE( FLyraLearningEditorModule, LyraLearningEditor);
