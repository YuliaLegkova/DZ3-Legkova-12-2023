// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design.Serialization;
using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");
Console.WriteLine("a*x^2+b*x+c=0");
Console.WriteLine("Введите целые значения а, b и с");

var a = 0;
var b = 0;
var c = 0;
var x = 0;
double x1 = 0.0;
double x2 = 0.0;

a = GetABC("Введите значение а:");
b = GetABC("Введите значение b:");
c = GetABC("Введите значение c:");

Console.WriteLine("a =" + a);
Console.WriteLine("b =" + b);
Console.WriteLine("C =" + c);
var d = Math.Pow(b, 2) - (4 * a * c);

var d1 = Math.Sqrt(d);
Console.WriteLine("d = " + d);
Console.WriteLine("d1 = " + d1);


if (d < 0)
    Console.WriteLine("Вещественных значений не найдено");
else if (d == 0)
{
    Console.WriteLine("Корень уравнения: ");
    x = (-b) / (2 * a);
    Console.WriteLine("x = " + x);
}

else
{
    Console.WriteLine("Корни уравнения: ");
    x1 = ((-b) + d1) / (2 * a);
    x2 = ((-b) - d1) / (2 * a);
    Console.WriteLine("x1 = " + x1 + ", " + "x2 = " + x2);
    
}
static int GetABC(string v)
{
    while (true)
    {
        Console.WriteLine(v);
        var str = 0;

        if (Int32.TryParse(Console.ReadLine(), out str))
        {
            return str;
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            string argument = "";
            string argument1 = "";
            string[] arr = v.Split();
            argument = arr[2];
            argument1 = argument.Substring(0,1);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Некорректное значение параметра " + argument1);
            Console.WriteLine("---------------------------------");
            Console.ResetColor();
        }
    }
}