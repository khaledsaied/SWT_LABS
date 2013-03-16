namespace WeighingSystemTest
{
    class WeighingSystemTest 
    {
        static void Main(string[] args)
        {
            var uut = new WeighingSystem.WeighingSystem(null);
            uut.SetUnit(WeighingSystem.WeighingUnit.UnitKg);
            uut.WeighGoods();   // not really much of a test, but anyway...

        }
    }
}
