using Tyuiu.PlatonovaPE.Sprint3.Task6.V8.Lib;
namespace Tyuiu.PlatonovaPE.Sprint3.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 18;
            int stopValue = 28;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 273;

            Assert.AreEqual(wait, res);
        }
    }
}