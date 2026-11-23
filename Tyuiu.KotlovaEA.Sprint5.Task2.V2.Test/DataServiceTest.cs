using Tyuiu.KotlovaEA.Sprint5.Task2.V2.Lib;
namespace Tyuiu.KotlovaEA.Sprint5.Task2.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mtrx = new int[3, 3] {
                { -7, 7, 5 },
                { 4, 2, -7 },
                { 2, 6, -4 }
            };

            string path = ds.SaveToFileTextData(mtrx);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.IsTrue(fileExists);
        }
    }
}
