using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using Tyuiu.PlatonovaPE.Sprint3.Task6.V8.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #2 | Выполнила: Платонова Полина Евгеньвна  | ИСПб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла for                *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #8                                                             *");
Console.WriteLine("* Выполнила:  Платонова Полина Евгеньвна  | ИСПб-24-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программy, которая ищет среди целых чисел, принадлежащих числовому отрезку     *");
Console.WriteLine("* [18, 28] сумму всех делителей больше 11       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
int startValue = 18;
int stopValue = 28;

Console.WriteLine("Старт шага:" + startValue);
Console.WriteLine("Конец шага:" + stopValue);



Console.WriteLine("********************************************************************************");
Console.WriteLine("* Результат:                                                                   *");
Console.WriteLine("********************************************************************************");


Console.WriteLine("Сумма  = " + ds.GetSumTheDivisors(startValue, stopValue));

Console.ReadKey();


