using NUnit.Framework;


namespace WeighingSystem.Test
{
    [TestFixture]
    public class WeighingUnitTest
    {
        [Test]
        public void GetWeight_Test()
        {
            Log log = new Log("khaled", false);
            Weight weight = new Weight();
            IWeighingUnit Interface = new WeighingUnit(log, weight);
            Assert.AreEqual(Interface.GetWeight(), 100);
        }
     
    }
}
