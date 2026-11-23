using Tyuiu.KotlovaEA.Sprint5.Task6.V25.Lib;
namespace Tyuiu.KotlovaEA.Sprint5.Task6.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string tempPath = Path.GetTempFileName();

            File.WriteAllText(tempPath, "Привет! Как дела?! Отлично!!!");

            int res = ds.LoadFromDataFile(tempPath);

            int expected = 5;

            Assert.AreEqual(expected, res);
        }
    }
}
