using Tyuiu.KotlovaEA.Sprint5.Task5.V22.Lib;
namespace Tyuiu.KotlovaEA.Sprint5.Task5.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string tempPath = Path.GetTempFileName();

            File.WriteAllText(tempPath, "19.03 11 5 1 16 18 -2 17 -10 19.91");

            double res = ds.LoadFromDataFile(tempPath);

            double expected = 16;

            Assert.AreEqual(expected, res);
        }
    }
}
