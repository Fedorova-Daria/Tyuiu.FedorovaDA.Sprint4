using Tyuiu.FedorovaDA.Sprint4.Task0.V15.Lib;
namespace Tyuiu.FedorovaDA.Sprint4.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int res = ds.GetMultOddArrEl(numsArray);
            Assert.AreEqual(945, res);
        }
    }
}