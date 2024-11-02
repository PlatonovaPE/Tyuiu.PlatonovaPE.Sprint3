using Tyuiu.PlatonovaPE.Sprint3.Task1.V25.Lib;
namespace Tyuiu.PlatonovaPE.Sprint3.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int value = 2;
            int startValue = 1;
            int stopValue = 6;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 36.741;

            Assert.AreEqual(res, wait);
        }
    }
}