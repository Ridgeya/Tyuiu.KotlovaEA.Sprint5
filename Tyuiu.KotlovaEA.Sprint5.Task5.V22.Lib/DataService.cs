using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.KotlovaEA.Sprint5.Task5.V22.Lib
{
    public class DataService : ISprint5Task5V22
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);

            string[] strNums = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double minDivisible = double.MaxValue;
            bool found = false;

            foreach (string s in strNums)
            {
                string cleanStr = s.Replace(',', '.');

                if (double.TryParse(cleanStr, System.Globalization.CultureInfo.InvariantCulture, out double num))
                {
                    if (num % 1 == 0)
                    {
                        if (num % 4 == 0)
                        {
                            if (num < minDivisible)
                            {
                                minDivisible = num;
                                found = true;
                            }
                        }
                    }
                }
            }

            if (!found) return 0;

            return Math.Round(minDivisible, 3);
        }
    }
}
