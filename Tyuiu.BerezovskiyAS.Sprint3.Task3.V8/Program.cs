using Tyuiu.BerezovskiyAS.Sprint3.Task3.V8.Lib;
{
    DataService ds = new DataService();
    Console.Title = "Спринт #3 | Выполнил: Березовский А. С. | ПИНб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #3                                                               *");
    Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
    Console.WriteLine("* Задание #3                                                              *");
    Console.WriteLine("* Вариант #8                                                              *");
    Console.WriteLine("* Выполнил: Березовский Артём Станиславович | ПИНб-25-1                   *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Используя цикл foreach удалить все буквы и знаки препинания, оставить   *");
    Console.WriteLine("* цифру затем преобразовать в число в строке: vc,x12fc fc!e               *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");
    string str = "vc,x12fc fc!e";
    Console.WriteLine("* Исходная строка = " + str);
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");
    int res = ds.ConvertStringToInt(str);
    Console.WriteLine(res);
}