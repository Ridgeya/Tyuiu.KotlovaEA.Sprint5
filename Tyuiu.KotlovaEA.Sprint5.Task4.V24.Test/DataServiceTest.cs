using Tyuiu.KotlovaEA.Sprint5.Task4.V24.Lib;

namespace Tyuiu.KotlovaEA.Sprint5.Task4.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string tempPath = Path.GetTempFileName();

            File.WriteAllText(tempPath, "3.79");

            double res = ds.LoadFromDataFile(tempPath);

            double expected = -1.25;

            Assert.AreEqual(expected, res);
        }
    }
}
