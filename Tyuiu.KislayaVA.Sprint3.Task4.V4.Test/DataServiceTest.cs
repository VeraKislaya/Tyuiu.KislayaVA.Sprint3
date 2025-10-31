using Tyuiu.KislayaVA.Sprint3.Task4.V4.Lib;

namespace Tyuiu.KislayaVA.Sprint3.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void ValidCalculate()
        {
            Assert.AreEqual(ds.Calculate(-5, 5), -35.317);
        }
    }
}
