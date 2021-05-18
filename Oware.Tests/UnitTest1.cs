using NUnit.Framework;

namespace Oware.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenResetHouseSeedsShouldBeFour()
        {
            //ARRANGE
            //nothing here
            //ACT
            House h = new House(0, 0);
            h.ResetHouse();
            //ASSERT
            Assert.AreEqual(4, h.GetCount(), "Reset  houses must have 4 seeds in them.");
        }
    }
}

// The Player class depends on ScoreHouse. Use a mock to test
// AddSeedToScoreHouse and check that it does, in fact, call ScoreHouse’s 
//AddSeed method.