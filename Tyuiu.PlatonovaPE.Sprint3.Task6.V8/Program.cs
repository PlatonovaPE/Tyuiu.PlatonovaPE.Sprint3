using System.ComponentModel;
using System.ComponentModel.Design;
using Tyuiu.PlatonovaPE.Sprint3.Task6.V8.Lib;

DataService ds = new DataService();

Console.WriteLine("********************************************************************************");
Console.WriteLine("* Исходные данные                                                              *");
Console.WriteLine("********************************************************************************");

int startValue = 18;
int stopValue = 28;

Console.WriteLine("Старт шага:" + startValue);
Console.WriteLine("Конец шага:" + stopValue);



Console.WriteLine("********************************************************************************");
Console.WriteLine("* Результат:                                                                   *");
Console.WriteLine("********************************************************************************");

Console.WriteLine("Сумма  = " + ds.GetSumTheDivisors(startValue, stopValue));

Console.ReadKey();


