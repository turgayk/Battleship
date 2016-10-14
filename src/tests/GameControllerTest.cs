using NUnit.Framework;
using SwinGameSDK;

[TestFixture]
public class GameControllerTest
{
	[Test]
	public void TestCreateEasyPlayer() {
		AIPlayer ai = GameController.CreateAIPlayer(AIOption.Easy);
		Assert.IsTrue(ai is AIEasyPlayer);
	}
	
	[Test]
	public void TestCreateMediumPlayer() {
		AIPlayer ai = GameController.CreateAIPlayer(AIOption.Medium);
		Assert.IsTrue(ai is AIMediumPlayer);
	}
	
	[Test]
	public void TestCreateHardPlayer() {
		AIPlayer ai = GameController.CreateAIPlayer(AIOption.Hard);
		Assert.IsTrue(ai is AIHardPlayer);
	}
}