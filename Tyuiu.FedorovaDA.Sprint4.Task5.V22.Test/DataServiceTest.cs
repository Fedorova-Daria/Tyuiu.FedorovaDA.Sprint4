using Tyuiu.FedorovaDA.Sprint4.Task5.V22.Lib;
namespace Tyuiu.FedorovaDA.Sprint4.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] nums = new int[3, 3] { { -1, 2, 3 }, { 4, -5, 6 }, { 5, 6, 7 } };
            int res = ds.Calculate(nums);
            Assert.AreEqual(2, res);
        } 
    }
}