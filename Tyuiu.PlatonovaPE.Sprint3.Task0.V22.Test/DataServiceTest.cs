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
            int startValue = 2;
            int stopValue = 7;

            double res = ds.GetMultiplySeries(value,startValue, stopValue);

            double wait = 32.607;

            Assert.AreEqual(wait, res);
        }
    }
}