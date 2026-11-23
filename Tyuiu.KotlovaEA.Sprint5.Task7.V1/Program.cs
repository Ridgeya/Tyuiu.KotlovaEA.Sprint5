using Tyuiu.KotlovaEA.Sprint5.Task7.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнила: Котлова Е.А. | АСОиУБ-26-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Обработка файлов в C#                                             *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнила: Котлова Елизавета Алексеевна | АСОиУБ-26-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл с набором символьных данных. Удалить все цифры из файла.       *");
        Console.WriteLine("* Полученный результат сохранить в файл OutPutFileTask7V1.txt.            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\DataSprint5\InPutDataFileTask7V1.txt";
        Console.WriteLine("Входной файл: " + path);

        if (!File.Exists(path))
        {
            Console.WriteLine("Ошибка: Файл не найден! Убедитесь, что он лежит в C:\\DataSprint5\\");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.LoadDataAndSave(path);

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");

        Console.WriteLine("Содержимое: " + File.ReadAllText(res));
        Console.WriteLine();
        Console.ReadKey();
    }
}