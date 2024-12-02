using Tyuiu.KonstantinovaJN.Sprint4.Task2.V15.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint4.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 5, 4, 3, 4, 2, 3, 2, 5, 6, 2, 6 };

            int res = ds.Calculate(numsArray);
            int wait = 26;

            Assert.AreEqual(wait, res);
        }
    }
}