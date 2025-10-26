using Tyuiu.PozdeevaEA.Sprint3.Task7.V12.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Поздеева Е. А. | ПКТб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #12                                                             *");
        Console.WriteLine("* Выполнил: Поздеева Елизавета Александровна | ПКТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
        Console.WriteLine("*                    2                                                    *");
        Console.WriteLine("* F(x) = sin(x) + ------ - 2 * cos(x) * 2 * x                             *");
        Console.WriteLine("*                 3x+0.5                                                  *");
        Console.WriteLine("* (произвести табулирование) f(x) на заданном диапазоне [-5; 5] с шагом 1.*");
        Console.WriteLine("* Произвести проверку деления на ноль. При делении на ноль вернуть        *");
        Console.WriteLine("* значение 0. Значения занести в массив. Значения округлить до двух       *");
        Console.WriteLine("* знаков после запятой.                                                   *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        int len = ds.GetMassFunction(startValue, stopValue).Length;

        double[] value;
        value = new double[len];

        value = ds.GetMassFunction(startValue,stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine("+------------+-------------+");
        Console.WriteLine("|      x     |     f(x)    |");
        Console.WriteLine("+------------+-------------+");
        for (int i = 0; i <=len-1; i++)
        {
            Console.WriteLine("|{0,6:d}      |   {1,6:f2}    |", startValue, value[i]);
            startValue++;
        }
        Console.WriteLine("+------------+-------------+");

        Console.ReadKey();
    }
}