using Tyuiu.KotlovaEA.Sprint5.Task4.V24.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнила: Котлова Е.А. | АСОиУБ-26-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Обработка файлов в C#                                             *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #24                                                             *");
        Console.WriteLine("* Выполнила: Котлова Елизавета Алексеевна | АСОиУБ-26-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл с вещественным значением. Прочитать значение из файла и        *");
        Console.WriteLine("* подставить вместо X в формулу y = (x^-2 + 2)*sin(x).                    *");
        Console.WriteLine("* Вычислить значение и вернуть результат (округлить до 3 знаков).         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\DataSprint5\InPutDataFileTask4V24.txt";
        Console.WriteLine("Путь к файлу: " + path);

        if (!File.Exists(path))
        {
            Console.WriteLine("Ошибка: Файл не найден по указанному пути!");
            Console.WriteLine("Убедитесь, что вы создали папку C:\\DataSprint5\\ и положили туда файл.");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.LoadFromDataFile(path);

        Console.WriteLine("Результат: " + res);
        Console.WriteLine();
        Console.ReadKey();
    }
}