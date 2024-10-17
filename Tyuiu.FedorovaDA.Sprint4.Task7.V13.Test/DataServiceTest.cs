using Tyuiu.FedorovaDA.Sprint4.Task7.V13.Lib;
namespace Tyuiu.FedorovaDA.Sprint4.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int rows = 3;
            int colums = 3;
            int[,] mtrx = new int[rows, colums];
            string str = "159357246";
            int res = ds.Calculate(rows, colums, str);
            Assert.AreEqual(3, res);
        }
    }
}