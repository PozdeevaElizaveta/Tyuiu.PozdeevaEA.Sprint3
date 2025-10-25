using Tyuiu.PozdeevaEA.Sprint3.Task1.V29.Lib;
namespace Tyuiu.PozdeevaEA.Sprint3.Task1.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 11;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 13051.340;
            Assert.AreEqual(res, wait);
        }
    }
}
