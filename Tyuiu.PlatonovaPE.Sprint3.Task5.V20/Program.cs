﻿using System.ComponentModel;
using System.ComponentModel.Design;
using Tyuiu.PlatonovaPE.Sprint3.Task5.V20.Lib;

DataService ds = new DataService();

Console.WriteLine("********************************************************************************");
Console.WriteLine("* Исходные данные                                                              *");
Console.WriteLine("********************************************************************************");

int x = 5;
int startValue1 = 1;
int stopValue1 = 3;
int startValue2 = 1;
int stopValue2 = 6;

Console.WriteLine("Введите  значение X:" + x);
Console.WriteLine("Старт шага:" + startValue1);
Console.WriteLine("Конец шага:" + stopValue1);
Console.WriteLine("Старт шага:" + startValue2);
Console.WriteLine("Конец шага:" + stopValue2);


Console.WriteLine("********************************************************************************");
Console.WriteLine("* Результат:                                                                   *");
Console.WriteLine("********************************************************************************");

Console.WriteLine("Произведение ряда = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));



Console.ReadKey();
