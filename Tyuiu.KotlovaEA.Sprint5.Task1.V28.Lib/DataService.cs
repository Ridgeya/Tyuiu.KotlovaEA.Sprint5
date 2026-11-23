using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using Tyuiu.KotlovaEA.Sprint5.Task1.V28.Lib;
namespace Tyuiu.KotlovaEA.Sprint5.Task1.V28.Lib
{
    public class DataService : ISprint5Task1V28
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            double y;
            string strY;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0.7)
                {
                    y = 0;
                }
                else
                {
                    y = (Math.Cos(x) / (x - 0.7)) - (Math.Sin(x) * 12 * x) + 2;

                    y = Math.Round(y, 2);
                }

                strY = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }

            return path;
        }
    }
}
