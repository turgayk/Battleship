using NUnit.Framework;
using SwinGameSDK;

[TestFixture]
public class DeploymentControllerTest
{
	[Test]
	public void TestLeftRightButtonRotatesShip()
	{
		DeploymentController.AdjustShipDirectionFromButtons(LeftRightButtonClicked);
		
		Assert.AreEqual(Direction.LeftRight, DeploymentController._currentDirection);
	}
	
	[Test]
	public void TestUpDownButtonRotatesShip()
	{
		DeploymentController.AdjustShipDirectionFromButtons(UpDownButtonClicked);
		
		Assert.AreEqual(Direction.UpDown, DeploymentController._currentDirection);
	}
	
	private static bool UpDownButtonClicked(int x, int y, int width, int height) {
		// use the paramiters passed to test what button is being checked for
		return x == DeploymentController.UP_DOWN_BUTTON_LEFT 
			&& y == DeploymentController.TOP_BUTTONS_TOP 
			&& width == DeploymentController.DIR_BUTTONS_WIDTH 
			&& height == DeploymentController.TOP_BUTTONS_HEIGHT;
	}
	
	private static bool LeftRightButtonClicked(int x, int y, int width, int height) {
		// use the paramiters passed to test what button is being checked for
		return x == DeploymentController.LEFT_RIGHT_BUTTON_LEFT 
			&& y == DeploymentController.TOP_BUTTONS_TOP 
			&& width == DeploymentController.DIR_BUTTONS_WIDTH 
			&& height == DeploymentController.TOP_BUTTONS_HEIGHT;
	}
}