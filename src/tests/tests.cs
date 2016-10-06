using NUnit.Framework;

[TestFixture]
public class Tester
{
	[Test]
	public void ATest()
	{
		Assert.IsTrue( false, "At least the test ran!" );
	}
}