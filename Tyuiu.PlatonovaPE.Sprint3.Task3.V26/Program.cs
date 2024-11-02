using Tyuiu.PlatonovaPE.Sprint3.Task3.V26.Lib;
using System.ComponentModel;
using System.ComponentModel.Design;

DataService ds = new DataService();

Console.WriteLine("********************************************************************************");
Console.WriteLine("* Исходные данные                                                              *");
Console.WriteLine("********************************************************************************");

string value = "have a nice time";
char chr = 'e';

Console.WriteLine("Исходная строка:" + value);
Console.WriteLine("Искомый символ:" + chr);


Console.WriteLine("********************************************************************************");
Console.WriteLine("* Результат:                                                                   *");
Console.WriteLine("********************************************************************************");

Console.WriteLine("Количество символов = " + ds.GetCharCount(value,chr));



Console.ReadKey();

