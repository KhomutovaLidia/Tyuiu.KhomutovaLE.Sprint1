using Tyuiu.KhomutovaLE.Sprint1.Task5.V6.Lib;

namespace Tyuiu.KhomutovaLE.Sprint1.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidEx()
        {
            DataService ds = new DataService();
            int n = 235;
            var res = ds.Calculate(n);
            Assert.AreEqual(4, res);
        }
    }
}
