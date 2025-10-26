using Tyuiu.PozdeevaEA.Sprint3.Task2.V9.Lib;
namespace Tyuiu.PozdeevaEA.Sprint3.Task2.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 0.042;
            Assert.AreEqual(res, wait);
        }
    }
}
