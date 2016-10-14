using NUnit.Framework;
using SwinGameSDK;

[TestFixture]
public class MenuControllerTest
{
	
	[Test]
	public void TestSetEasyPlayer()
	{
		GameController.AddNewState(GameState.AlteringSettings);
		MenuController.PerformSetupMenuAction(MenuController.SETUP_MENU_EASY_BUTTON);
		
		Assert.AreEqual(GameController.GetDifficulty(), AIOption.Easy);
	}
	
	[Test]
	public void TestSetMediumPlayer()
	{
		GameController.AddNewState(GameState.AlteringSettings);
		MenuController.PerformSetupMenuAction(MenuController.SETUP_MENU_MEDIUM_BUTTON);
		
		Assert.AreEqual(GameController.GetDifficulty(), AIOption.Medium);
	}
	
	[Test]
	public void TestSetHardPlayer()
	{
		GameController.AddNewState(GameState.AlteringSettings);
		MenuController.PerformSetupMenuAction(MenuController.SETUP_MENU_HARD_BUTTON);
		
		Assert.AreEqual(GameController.GetDifficulty(), AIOption.Hard);
	}
	
}