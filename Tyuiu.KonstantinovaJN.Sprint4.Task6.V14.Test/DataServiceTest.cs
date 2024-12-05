using Tyuiu.KonstantinovaJN.Sprint4.Task6.V14.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint4.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValisCalculate()
        {
            DataService ds = new DataService();

            var months = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль" };

            string[] res = ds.Calculate(months);

            Assert.AreEqual(6, res.Length);
            CollectionAssert.AreEqual(new string[] { "Январь", "Февраль", "Март", "Апрель", "Июнь", "Июль" }, res);
        }
    }
}