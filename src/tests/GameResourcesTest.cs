using NUnit.Framework;
using SwinGameSDK;

[TestFixture()]
public class BattleshipPlayATestHF
{
	[Test]
	public void AlignDeployment()
	{
		Assert.NotNull(Audio.LoadSoundEffect("siren.wav"));
	}
}

