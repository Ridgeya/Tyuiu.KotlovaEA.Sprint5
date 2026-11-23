using Tyuiu.KotlovaEA.Sprint5.Task6.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнила: Котлова Е.А. | АСОиУБ-26-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Обработка файлов в C#                                             *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #25                                                             *");
        Console.WriteLine("* Выполнила: Котлова Елизавета Алексеевна | АСОиУБ-26-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл с набором символьных данных. Найти количество знаков           *");
        Console.WriteLine("* восклицания в заданной строке.                                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\DataSprint5\InPutDataFileTask6V25.txt";
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

        int res = ds.LoadFromDataFile(path);

        Console.WriteLine("Количество восклицательных знаков: " + res);
        Console.WriteLine();
        Console.ReadKey();
    }
}