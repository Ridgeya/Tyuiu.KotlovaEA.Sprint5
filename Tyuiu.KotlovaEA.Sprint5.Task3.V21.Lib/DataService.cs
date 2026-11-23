using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KotlovaEA.Sprint5.Task3.V21.Lib
{
    public class DataService : ISprint5Task3V21
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            double numerator = Math.Pow(x, 2) + 1;
            double denominator = Math.Sqrt(4 * Math.Pow(x, 2) - 3);

            double y = numerator / denominator;

            y = Math.Round(y, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(y);
            }

            return path;
        }
    }
}
