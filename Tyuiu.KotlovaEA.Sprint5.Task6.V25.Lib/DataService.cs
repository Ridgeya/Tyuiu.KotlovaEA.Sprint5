using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KotlovaEA.Sprint5.Task6.V25.Lib
{
    public class DataService : ISprint5Task6V25
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);

            int count = 0;
            foreach (char c in text)
            {
                if (c == '!')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
