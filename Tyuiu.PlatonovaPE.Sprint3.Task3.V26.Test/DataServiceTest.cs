using Tyuiu.PlatonovaPE.Sprint3.Task3.V26.Lib;
namespace Tyuiu.PlatonovaPE.Sprint3.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest 
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string str = "have a nice time";

            char chr = 'e';

            double res = ds.GetCharCount(str, chr);
            int wait = 6;
            Assert.AreEqual(wait, res);

        }
    }
}