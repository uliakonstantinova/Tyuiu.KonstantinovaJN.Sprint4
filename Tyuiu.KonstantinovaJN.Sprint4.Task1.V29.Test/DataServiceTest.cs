using Tyuiu.KonstantinovaJN.Sprint4.Task1.V29.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint4.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 5, 3, 3, 4, 1, 3, 3, 5, 6, 2, 7, 2, 1, 8 };

            int res = ds.Calculate(numsArray);
            int wait = 31;

            Assert.AreEqual(wait, res);
        }
    }
}