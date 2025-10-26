using Tyuiu.PozdeevaEA.Sprint3.Task4.V2.Lib;
namespace Tyuiu.PozdeevaEA.Sprint3.Task4.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);
            double wait = 0.104;
            Assert.AreEqual(res, wait);
        }
    }
}
