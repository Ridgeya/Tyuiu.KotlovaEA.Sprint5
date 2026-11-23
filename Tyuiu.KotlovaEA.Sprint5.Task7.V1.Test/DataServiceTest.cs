using Tyuiu.KotlovaEA.Sprint5.Task7.V1.Lib;
namespace Tyuiu.KotlovaEA.Sprint5.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string tempPathRead = Path.GetTempFileName();

            File.WriteAllText(tempPathRead, "123 Привет 456!");

            string resPath = ds.LoadDataAndSave(tempPathRead);

            string actualResult = File.ReadAllText(resPath);

            string expected = " Привет !";

            Assert.AreEqual(expected, actualResult);
        }
    }
}
