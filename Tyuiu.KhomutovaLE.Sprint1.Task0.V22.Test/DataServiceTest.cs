using Tyuiu.KhomutovaLE.Sprint1.Task0.V22.Lib;

namespace Tyuiu.KhomutovaLE.Sprint1.Task0.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidEx()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(10, res);
        }
    }
}
