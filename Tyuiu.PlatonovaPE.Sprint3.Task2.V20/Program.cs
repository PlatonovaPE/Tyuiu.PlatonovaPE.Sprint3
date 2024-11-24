using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using Tyuiu.PlatonovaPE.Sprint3.Task2.V20.Lib;

DataService ds = new DataService();

CConsole.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла for                *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #20                                                             *");
Console.WriteLine("* Выполнила:  Платонова Полина Евгеньвна  | ИСПб-24-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет         *");
Console.WriteLine("* произведение ряда по формуле, при x = 1                                 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int value = 1;
int startValue = 1;
int stopValue = 6;

Console.WriteLine("Введите  значение X:" + value);
Console.WriteLine("Старт шага:" + startValue);
Console.WriteLine("Конец шага:" + stopValue);


Console.WriteLine("********************************************************************************");
Console.WriteLine("* Результат:                                                                   *");
Console.WriteLine("********************************************************************************");

Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));



Console.ReadKey();

