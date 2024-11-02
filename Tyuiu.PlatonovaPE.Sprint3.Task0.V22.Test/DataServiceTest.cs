using Tyuiu.PlatonovaPE.Sprint3.Task0.V22.Lib;
namespace Tyuiu.PlatonovaPE.Sprint3.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 8;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 6.747;

            Assert.AreEqual(wait, res);
        }
    }
}