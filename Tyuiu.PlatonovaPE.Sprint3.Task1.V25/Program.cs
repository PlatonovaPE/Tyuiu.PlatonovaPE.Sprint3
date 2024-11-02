using System.ComponentModel;
using System.ComponentModel.Design;
using Tyuiu.PlatonovaPE.Sprint3.Task1.V25.Lib;

DataService ds = new DataService();

Console.WriteLine("********************************************************************************");
Console.WriteLine("* Исходные данные                                                              *");
Console.WriteLine("********************************************************************************");

int value = 2;
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

