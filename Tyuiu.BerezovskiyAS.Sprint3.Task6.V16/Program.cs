using Tyuiu.BerezovskiyAS.Sprint3.Task6.V16.Lib;
{
    DataService ds = new DataService();

    Console.Title = "Спринт #3 | Выполнил: Березовский А. С. | ПИНб-25-1";

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #3                                                               *");
    Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
    Console.WriteLine("* Задание #6                                                              *");
    Console.WriteLine("* Вариант #16                                                             *");
    Console.WriteLine("* Выполнил: Березовский Артём Станиславович | ПИНб-25-1                   *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Напишите программу, которая ищет среди целых чисел,                     *");
    Console.WriteLine("* принадлежащих числовому отрезку [5, 16] количество всех делителей.      *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    int startValue = 5;
    int stopValue = 16;

    Console.WriteLine("Начало отрезка: " + startValue);
    Console.WriteLine("Конец отрезка: " + stopValue);

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("Количество делителей = " + ds.GetSumTheDivisors(startValue, stopValue));

    Console.ReadKey();
}