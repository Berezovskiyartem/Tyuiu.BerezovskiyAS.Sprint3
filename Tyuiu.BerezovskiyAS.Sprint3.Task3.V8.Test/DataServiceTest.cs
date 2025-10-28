using Tyuiu.BerezovskiyAS.Sprint3.Task3.V8.Lib;
namespace Tyuiu.BerezovskiyAS.Sprint3.Task3.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ConvertStringToInt()
        {
            DataService ds = new DataService();
            string str = "vc,x12fc fc!e";
            int wait = 12;

            int res = ds.ConvertStringToInt(str);
            Assert.AreEqual(wait, res);
        }
    }
}
