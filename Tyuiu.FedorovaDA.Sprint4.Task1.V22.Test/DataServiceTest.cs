using Tyuiu.FedorovaDA.Sprint4.Task1.V22.Lib;
namespace Tyuiu.FedorovaDA.Sprint4.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] nums = { 1, 2, 3 };
            int res = ds.Calculate(nums);
            Assert.AreEqual(3, res);
        }
    }
}