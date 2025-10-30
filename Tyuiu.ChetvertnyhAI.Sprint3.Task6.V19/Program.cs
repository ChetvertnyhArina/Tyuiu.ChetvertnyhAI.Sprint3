using Tyuiu.ChetvertnyhAI.Sprint3.Task6.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнила: Четвертных А. И. | ИСТНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #19                                                             *");
        Console.WriteLine("* Выполнила: Четвертных Арина Игоревна | ИСТНб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* найти количество всех делителей меньше 8 на отрезке [10, 15]            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        DataService ds = new DataService();
        int startValue = 10;
        int stopValue = 15;
        Console.WriteLine("Начало отрезка = " + startValue);
        Console.WriteLine("Конец отрезка = " + stopValue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Количество делителей меньше 8 = " + ds.GetSumTheDivisors( startValue,  stopValue));
        Console.ReadKey();
    }
}