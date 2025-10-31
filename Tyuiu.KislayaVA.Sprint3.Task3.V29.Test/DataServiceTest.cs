using Tyuiu.KislayaVA.Sprint3.Task3.V29.Lib;

namespace Tyuiu.KislayaVA.Sprint3.Task3.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            string a = "tqqe eqwt";
            char b = 't';
            string res = ds.DeleteCharInString(a,b);
            Assert.AreEqual("qqe eqw", res);
        }
    }
}
