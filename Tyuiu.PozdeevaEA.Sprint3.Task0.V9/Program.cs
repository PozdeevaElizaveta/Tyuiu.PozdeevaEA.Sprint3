using Tyuiu.PozdeevaEA.Sprint3.Task0.V9.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Поздеева Е. А. | ПКТб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #9                                                              *");
        Console.WriteLine("* Выполнил: Поздеева Елизавета Александровна | ПКТб-25-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда     *");
        Console.WriteLine("* по формуле, при x = 0,5                                                 *");
        Console.WriteLine("*      15       1   i                                                     *");
        Console.WriteLine("* S = summ  (------)                                                      *");
        Console.WriteLine("*      i=1       i                                                        *");
        Console.WriteLine("*             3+x                                                         *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double value = 0.5;
        int startValue = 1;
        int stopValue = 15;

        Console.WriteLine("Переменная X = " + value);
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

       
        Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value,startValue,stopValue));
        

        Console.ReadKey();
    }
}