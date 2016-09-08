
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using SwinGameSDK;

static class GameLogic
{
	public static void Main()
	{
		//Opens a new Graphics Window
		SwinGame.OpenGraphicsWindow("Battle Ships", 800, 600);

		//Load Resources
		GameResources.LoadResources();

		SwinGame.PlayMusic(GameResources.GameMusic("Background"));

		//Game Loop
		Console.WriteLine("Starting game");
		do {
			Console.WriteLine("Doing loop");
			GameController.HandleUserInput();
			GameController.DrawScreen();
			Console.WriteLine("Finished loop");
		} while (!(SwinGame.WindowCloseRequested() == true | GameController.CurrentState == GameState.Quitting));

		Console.WriteLine("Quitting");
		
		SwinGame.StopMusic();

		//Free Resources and Close Audio, to end the program.
		GameResources.FreeResources();
	}
}
