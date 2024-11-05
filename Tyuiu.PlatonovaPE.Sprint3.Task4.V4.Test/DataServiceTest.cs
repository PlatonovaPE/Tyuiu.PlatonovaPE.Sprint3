using Tyuiu.PlatonovaPE.Sprint3.Task4.V4.Lib;
namespace Tyuiu.PlatonovaPE.Sprint3.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = -35.317;
            Assert.AreEqual(res, wait);
        }
    }
}