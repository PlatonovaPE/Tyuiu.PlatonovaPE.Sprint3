using System.ComponentModel;
using System.ComponentModel.Design;
using Tyuiu.PlatonovaPE.Sprint3.Task0.V22.Lib;

DataService ds = new DataService();

Console.WriteLine("********************************************************************************");
Console.WriteLine("* Исходные данные                                                              *");
Console.WriteLine("********************************************************************************");

double value = 0.25;
int startValue = 2;
int stopValue = 7;

Console.WriteLine("Введите  значение Х:" + value);
Console.WriteLine("Старт шага:" + startValue);
Console.WriteLine("Конец шага:" + stopValue);


Console.WriteLine("********************************************************************************");
Console.WriteLine("* Результат:                                                                   *");
Console.WriteLine("********************************************************************************");

Console.WriteLine("Сумма рада = " + ds.GetMultiplySeries(value, startValue, stopValue));



Console.ReadKey();
