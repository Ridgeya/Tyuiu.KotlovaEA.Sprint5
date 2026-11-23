using Tyuiu.KotlovaEA.Sprint5.Task3.V21.Lib;
namespace Tyuiu.KotlovaEA.Sprint5.Task3.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = ds.SaveToFileTextData(3);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.IsTrue(fileExists);
        }
    }
}
