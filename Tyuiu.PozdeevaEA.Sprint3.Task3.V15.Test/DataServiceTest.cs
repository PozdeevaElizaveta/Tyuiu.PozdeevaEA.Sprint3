using Newtonsoft.Json.Linq;
using Tyuiu.PozdeevaEA.Sprint3.Task3.V15.Lib;
namespace Tyuiu.PozdeevaEA.Sprint3.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMinCharCount()
        {
            DataService ds = new DataService();
            string value = "lrmmse mg sermmmrt";
            char m = 'm';
            int res = ds.GetMinCharCount(value, m);
            int wait = 2;
            Assert.AreEqual(res, wait);
        }
    }
}
