using Tyuiu.KonstantinovaJN.Sprint4.Task5.V30.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint4.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5]
            {
                { -1, 3, 0, 3, -2 },
                { 3, -1, 0, -2, 0 },
                { -2, 0, -1, 0, 3 },
                { -2, 4, 0, -2, 0 },
                { 3, 0, -1, -2, 0 }
            };

            int res = ds.Calculate(mas2);
            int wait = 19;

            Assert.AreEqual(wait, res);
        }
    }
}