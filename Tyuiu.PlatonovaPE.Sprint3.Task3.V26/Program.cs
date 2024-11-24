using Tyuiu.PlatonovaPE.Sprint3.Task3.V26.Lib;
using System.ComponentModel;
using System.ComponentModel.Design;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла for                *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #26                                                             *");
Console.WriteLine("* Выполнила:  Платонова Полина Евгеньвна  | ИСПб-24-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет         *");
Console.WriteLine("* произведение ряда по формуле, при x = 1                                 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
string value = "have a nice time";
char chr = 'e';

Console.WriteLine("Исходная строка:" + value);
Console.WriteLine("Искомый символ:" + chr);


Console.WriteLine("********************************************************************************");
Console.WriteLine("* Результат:                                                                   *");
Console.WriteLine("********************************************************************************");

Console.WriteLine("Количество символов = " + ds.GetCharCount(value,chr));



Console.ReadKey();

