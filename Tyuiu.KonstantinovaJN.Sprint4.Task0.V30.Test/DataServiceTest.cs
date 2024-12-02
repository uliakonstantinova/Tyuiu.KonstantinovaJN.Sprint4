using Tyuiu.KonstantinovaJN.Sprint4.Task0.V30.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint4.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();

            int[] numsArray = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            
            int numsWaitArray = 30;

            int res = ds.GetSumEvenArrEl(numsArray);

            Assert.AreEqual(numsWaitArray, res);

        }
    }
}