﻿using System.Collections;
using System.Data.Common;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("a" == "a");
        Console.WriteLine("a" == "A");
        Console.WriteLine(1 == 2);

        string myValue = "a";
        Console.WriteLine(myValue == "a");

    }
}