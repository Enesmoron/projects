using System.Collections;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        /*  string[] values = { "12.3", "45", "ABC", "11", "DEF" };

         decimal total = 0m;
         string message = "";

         foreach (var value in values)
         {
             decimal number; // stores the TryParse "out" value
             if (decimal.TryParse(value, out number))
             {
                 total += number;
             }
             else
             {
                 message += value;
             }
         }

         Console.WriteLine($"Message: {message}");
         Console.WriteLine($"Total: {total}"); */

        /*  int value1 = 12;
         decimal value2 = 6.2m;
         float value3 = 4.3f;

         int result1 = value1 / (int)value2;
         // Hint: You need to round the result to nearest integer (don't just truncate)
         Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

         // Your code here to set result2
         decimal result2 = (decimal)value2 / (decimal)value3;
         Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

         // Your code here to set result3
         float result3 = (float)value3 / (float)value1;
         Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
      */

        /*    string[] pallets = { "B14", "A11", "B12", "A13" };

           Console.WriteLine("Sorted...");
           Array.Sort(pallets);

           foreach (string pallet in pallets)
           {
               Console.WriteLine(pallet);
           }


           Array.Reverse(pallets);

           Console.WriteLine("reverse");

           foreach (string pallet in pallets)
           {
               Console.WriteLine(pallet);

           }


           Console.WriteLine("resizer");
           Array.Resize(ref pallets, 8);

           pallets[4] = "C01";
           pallets[5] = "C02";
           pallets[6] = "C012";
           pallets[7] = "C023";
           foreach (string pallet in pallets)
           {
               Console.WriteLine(pallet);

           }


           Array.Clear(pallets, 0, 3);
           Console.WriteLine("Clear");

           foreach (string pallet in pallets)
           {
               Console.WriteLine(pallet);

           }
    */



        /*  string value = "abc123";
         char[] valueArray = value.ToCharArray();
         Array.Reverse(valueArray);
         // string result = new string(valueArray);
         string result = String.Join(",", valueArray);
         Console.WriteLine(result);

         string[] items = result.Split(',');
         foreach (string item in items)
         {
             Console.WriteLine($"{item}..");
         } */

        string pangram = "The quick brown fox jumps over the lazy dog";
        char[] mypangram = pangram.ToCharArray();
        Array.Reverse(mypangram);
        Console.WriteLine(mypangram);

        string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
        string[] orderId = orderStream.Split(",");
        Array.Sort(orderId);
        foreach (string order in orderId)
        {
            if (order.Length != 4)
            {
                Console.WriteLine($"{order} , error in lenght");
            }
            else
            {
                Console.WriteLine(order);
            }
        }

    }

}