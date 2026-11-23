using Tyuiu.KotlovaEA.Sprint5.Task1.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнила: Котлова Е.А. | АСОиУБ-26-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Обработка файлов в C#                                             *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #28                                                             *");
        Console.WriteLine("* Выполнила: Котлова Елизавета Алексеевна | АСОиУБ-26-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана функция F(x) = cos(x)/(x-0.7) - sin(x)*12x + 2.                    *");
        Console.WriteLine("* Произвести табулирование f(x) на заданном диапазоне [-5; 5] с шагом 1.  *");
        Console.WriteLine("* Произвести проверку деления на ноль. При делении на ноль вернуть 0.     *");
        Console.WriteLine("* Результат сохранить в текстовый файл OutPutFileTask1.txt и вывести      *");
        Console.WriteLine("* на консоль в таблицу. Значения округлить до 2 знаков после запятой.     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = -5;
        int stopValue = 5;
        Console.WriteLine("Диапазон: от " + startValue + " до " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(startValue, stopValue);

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");

        string[] lines = System.IO.File.ReadAllLines(res);
        Console.WriteLine("  X  |   Y   ");
        Console.WriteLine("-----|--------");

        for (int i = 0; i < lines.Length; i++)
        {
            Console.WriteLine($"{startValue + i,3}  | {lines[i]}");
        }

        Console.WriteLine();
        Console.ReadKey();
    }
}