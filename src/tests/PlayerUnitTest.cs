using NUnit.Framework;
using SwinGameSDK;

[TestFixture]
public class BattleshipPlayTest
{
	[Test()]
	public void AlignDeployment(){
		BattlesipGame b= new BattleshipGame();
		Player player = new player(b);

		Ship tug = player.Ship(ShipName.Tug);
		Ship submarine = player.Ship(ShipName.Submarine);
		Ship destroyer = player.Ship(ShipName.Destroyer);
		Ship battleship = player.Ship(ShipName.Battleship);
		Ship aircrafCarrier = player.Ship(ShipName.AircrafCarrier);
		Assert.IsTrue(tug.Column == submarin.Column && submarine.Colume == destroyer.Column && destroyer.Column == battleship.Column && battleship.Column == aircraftCarrier.Column );
		)



	}
 }
