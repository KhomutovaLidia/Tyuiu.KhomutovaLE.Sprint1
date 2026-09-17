using Tyuiu.KhomutovaLE.Sprint1.Task6.V15.Lib;

namespace Tyuiu.KhomutovaLE.Sprint1.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidEx()
        {
            DataService ds = new DataService();
            string text = "Привет, как дела? Сколько тебе лет? Что делаешь?";
            var res = ds.CheckLettersCount(text);
            Assert.AreEqual(true, res);
        }
    }
}
