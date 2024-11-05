using Tyuiu.PlatonovaPE.Sprint3.Task4.V4.Lib;
using System.ComponentModel;
using System.ComponentModel.Design;

DataService ds = new DataService();

Console.WriteLine("********************************************************************************");
Console.WriteLine("* Исходные данные                                                              *");
Console.WriteLine("********************************************************************************");

int startValue = -5;
int stopValue = 5;

Console.WriteLine("Старт:" + startValue);
Console.WriteLine("Конец:" + stopValue);


Console.WriteLine("********************************************************************************");
Console.WriteLine("* Результат:                                                                   *");
Console.WriteLine("********************************************************************************");

Console.WriteLine("Сумма ряда = " + ds.Calculate(startValue, stopValue));



Console.ReadKey();

