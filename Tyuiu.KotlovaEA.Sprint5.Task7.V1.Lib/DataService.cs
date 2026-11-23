using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KotlovaEA.Sprint5.Task7.V1.Lib
{
    public class DataService : ISprint5Task7V1
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path);

            StringBuilder sb = new StringBuilder();

            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    sb.Append(c);
                }
            }

            string result = sb.ToString();

            string pathWrite = Path.Combine(Path.GetTempPath(), "OutPutFileTask7V1.txt");

            File.WriteAllText(pathWrite, result);

            return pathWrite;
        }
    }
}
