using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using Tyuiu.PlatonovaPE.Sprint3.Task7.V27.Lib;

DataService ds = new DataService();

Console.WriteLine("********************************************************************************");
Console.WriteLine("* Исходные данные                                                              *");
Console.WriteLine("********************************************************************************");

int startValue = -5;
int stopValue = 5;


int len = ds.GetMassFunction(startValue, stopValue).Length;


double[] valueWaitArray;
valueWaitArray = new double[len];

Console.WriteLine("Старт шага:" + startValue);
Console.WriteLine("Конец шага:" + stopValue);

valueWaitArray = ds.GetMassFunction(startValue, stopValue);

Console.WriteLine("********************************************************************************");
Console.WriteLine("* Результат:                                                                   *");
Console.WriteLine("********************************************************************************");

Console.WriteLine("+--------------+--------------+");
Console.WriteLine("|         x    |       f(x)   |");
Console.WriteLine("+--------------+--------------+");



for (int i = 0; i<= len-1; i++)
{
    Console.WriteLine("|{0,5:d}    |       {1, 5:f2}        |", startValue, valueWaitArray[i]);
    startValue++;
}


Console.WriteLine("+--------------+--------------+");

Console.ReadKey();


