using Tyuiu.PlatonovaPE.Sprint4.Task1.V7.Lib;
namespace Tyuiu.PlatonovaPE.Sprint4.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds  = new DataService();

            int[] array = { 2, 5, 3, 8, 2, 6, 2, 5, 5, 7, 4 };
            int wait = 24;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);

        }
    }
}