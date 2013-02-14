using NUnit.Framework;

namespace WeighingSystem.Test
{
    [TestFixture]
    class DisplayTest : AssertionHelper
    {
        [Test]
        public void Columns_GetProperty_SimpleValue()
        {
            var d = new Display(new Log("dummylog.txt", true));

            Expect(d.Columns,Is.EqualTo(60));
        }
    }
}
