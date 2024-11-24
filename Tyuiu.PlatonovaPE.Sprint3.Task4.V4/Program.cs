using Tyuiu.PlatonovaPE.Sprint3.Task4.V4.Lib;
using System.ComponentModel;
using System.ComponentModel.Design;

DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла for                *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #4                                                             *");
Console.WriteLine("* Выполнила:  Платонова Полина Евгеньвна  | ИСПб-24-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет         *");
Console.WriteLine("* произведение ряда по формуле, при x = 1                                 *"); 
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************"); 
int startValue = -5;
int stopValue = 5;

Console.WriteLine("Старт:" + startValue);
Console.WriteLine("Конец:" + stopValue);


Console.WriteLine("********************************************************************************");
Console.WriteLine("* Результат:                                                                   *");
Console.WriteLine("********************************************************************************");

Console.WriteLine("Сумма ряда = " + ds.Calculate(startValue, stopValue));



Console.ReadKey();

