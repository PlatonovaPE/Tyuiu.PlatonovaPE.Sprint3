using Newtonsoft.Json.Linq;
using Tyuiu.PlatonovaPE.Sprint3.Task2.V20.Lib;
namespace Tyuiu.PlatonovaPE.Sprint3.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int value = 1;
            int startValue = 1;
            int stopValue = 6;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 12353130442653.422;
            Assert.AreEqual(res, wait);


        }
    }
}