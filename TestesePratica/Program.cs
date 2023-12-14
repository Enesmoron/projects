using System.Collections;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {

        string hello = "Hello";
        string world = "World";
        Console.WriteLine(string.Format("{0} ...............{1}!", hello, world));
        Console.WriteLine("{0} {0} {0} ", hello, world);

        decimal price = 123.45m;
        int discount = 50;
        Console.WriteLine($"Price: {price:C} (Save {discount:C})");


    }

}

