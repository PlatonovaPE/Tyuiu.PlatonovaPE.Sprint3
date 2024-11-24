using System.ComponentModel;
using System.ComponentModel.Design;
using Tyuiu.PlatonovaPE.Sprint3.Task0.V22.Lib;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла for                *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #22                                                             *");
Console.WriteLine("* Выполнила:  Платонова Полина Евгеньвна  | ИСПб-24-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет         *");
Console.WriteLine("* произведение ряда по формуле, при x = 1                                 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************"); 
double value = 0.25;
int startValue = 1;
int stopValue = 8;

Console.WriteLine("Введите  значение A:" + value);
Console.WriteLine("Старт шага:" + startValue);
Console.WriteLine("Конец шага:" + stopValue);


Console.WriteLine("********************************************************************************");
Console.WriteLine("* Результат:                                                                   *");
Console.WriteLine("********************************************************************************");

Console.WriteLine("Сумма рада = " + ds.GetMultiplySeries(value, startValue, stopValue));



Console.ReadKey();
