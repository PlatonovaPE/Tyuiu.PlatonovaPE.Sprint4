using Tyuiu.PlatonovaPE.Sprint4.Task6.V30.Lib;
namespace Tyuiu.PlatonovaPE.Sprint4.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var three = new string[] { "������", "���", "�����", "�����", "����", "�����" };
            string[] res = ds.Calculate(three);
            string[] wait = { "������" };
            CollectionAssert.AreEqual(res, wait);   

        }
    }
}