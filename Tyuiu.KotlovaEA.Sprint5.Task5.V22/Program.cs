using Tyuiu.KotlovaEA.Sprint5.Task5.V22.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнила: Котлова Е.А. | АСОиУБ-26-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Обработка файлов в C#                                             *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #22                                                             *");
        Console.WriteLine("* Выполнила: Котлова Елизавета Алексеевна | АСОиУБ-26-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл с набором значений. Найти минимальное целое число в файле,     *");
        Console.WriteLine("* которое делится на 4. Результат вывести на консоль.                     *");
        Console.WriteLine("* У вещественных значений округлить до трёх знаков после запятой.         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\DataSprint5\InPutDataFileTask5V22.txt";
        Console.WriteLine("Путь к файлу: " + path);

        if (!File.Exists(path))
        {
            Console.WriteLine("Ошибка: Файл не найден! Убедитесь, что он лежит в C:\\DataSprint5\\");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.LoadFromDataFile(path);

        Console.WriteLine("Минимальное целое число, кратное 4: " + res);
        Console.WriteLine();
        Console.ReadKey();
    }
}