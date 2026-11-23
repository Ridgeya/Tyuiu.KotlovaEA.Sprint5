using Tyuiu.KotlovaEA.Sprint5.Task1.V28.Lib;

namespace Tyuiu.KotlovaEA.Sprint5.Task1.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = ds.SaveToFileTextData(-5, 5);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.IsTrue(fileExists);
        }
    }
}
