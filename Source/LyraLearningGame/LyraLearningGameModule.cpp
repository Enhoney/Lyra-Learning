// Copyright Epic Games, Inc. All Rights Reserved.

#include "Modules/ModuleManager.h"


/**
 * FLyraLearningGameModule
 */
class FLyraLearningGameModule : public FDefaultGameModuleImpl
{
	virtual void StartupModule() override
	{
	}

	virtual void ShutdownModule() override
	{
	}
};


IMPLEMENT_PRIMARY_GAME_MODULE(FLyraLearningGameModule, LyraLearningGame, "LyraLearningGame" );
