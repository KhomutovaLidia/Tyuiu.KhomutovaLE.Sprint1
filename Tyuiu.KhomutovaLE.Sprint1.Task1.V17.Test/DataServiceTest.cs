using Tyuiu.KhomutovaLE.Sprint1.Task1.V17.Lib;

namespace Tyuiu.KhomutovaLE.Sprint1.Task1.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidEx()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 3.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(18, res);
        }
    }
}
