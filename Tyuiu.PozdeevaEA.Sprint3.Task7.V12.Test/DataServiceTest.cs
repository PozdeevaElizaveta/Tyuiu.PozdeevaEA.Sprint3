using Tyuiu.PozdeevaEA.Sprint3.Task7.V12.Lib;
namespace Tyuiu.PozdeevaEA.Sprint3.Task7.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWait;
            valueWait = new double[len];
            valueWait[0] = 6.49;
            valueWait[1] = -9.88;
            valueWait[2] = -12.26;
            valueWait[3] = -4.60;
            valueWait[4] = 0.52;
            valueWait[5] = 4.00;
            valueWait[6] = -0.75;
            valueWait[7] = 4.55;
            valueWait[8] = 12.23;
            valueWait[9] = 9.86;
            valueWait[10] = -6.50;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(res, valueWait);

        }
    }
}
