using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using Tyuiu.PlatonovaPE.Sprint4.Task2.V1.Lib;

DataService ds = new DataService();

Console.WriteLine("********************************************************************************");
Console.WriteLine("* Исходные данные                                                              *");
Console.WriteLine("********************************************************************************");

int len;
Console.WriteLine("введите количество элементов массива");
len = Convert.ToInt32(Console.ReadLine());

int[] array = new int[len];

for (int i = 0; i <= array.Length - 1; i++)
{
    Console.WriteLine("Введите значение " + i + " элемента массива");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine("Массив:");
for (int i = 0; i <= len - 1; i++)
{
    Console.WriteLine(array[i] + "\t");
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("********************************************************************************");
Console.WriteLine("* Результат:                                                                   *");
Console.WriteLine("********************************************************************************");


int res = ds.Calculate(array);

Console.Write(res);

Console.ReadKey();




