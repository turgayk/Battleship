using NUnit.Framework;
using SwinGameSDK;

[TestFixture()]
public class BattleshipPlayATest
{
	[Test()]
	public void AlignDeployment()
	{

		BattleShipsGame b = new BattleShipsGame();
		Player player = new Player(b);

		Ship tug = player.Ship(ShipName.Tug);
		Ship submarine = player.Ship(ShipName.Submarine);
		Ship destroyer = player.Ship(ShipName.Destroyer);
		Ship battleship = player.Ship(ShipName.Battleship);
		Ship aircraftCarrier = player.Ship(ShipName.AircraftCarrier);
		Assert.IsTrue(tug.Column == submarine.Column && submarine.Column == destroyer.Column && destroyer.Column == battleship.Column && battleship.Column == aircraftCarrier.Column);
	}
}

