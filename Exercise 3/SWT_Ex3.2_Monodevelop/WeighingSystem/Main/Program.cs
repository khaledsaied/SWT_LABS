using WeighingSystem;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var ws = new WeighingController();
            var logger = new Log("testlog.txt", true);
            logger.LogMsg("Haha");
            logger.LogMsg("Hihi");
            var wu = new WeighingUnit(logger, new Weight());
            wu.DoLog = true;
            var kb = new Keyboard(logger);
            kb.DoLog = true;
            wu.GetWeight();
            uint row, col;
            kb.GetNextKeypress(out row,out col);
        }
    }
}
