# projects

pratica
Recapitulação
Para chamar métodos de uma classe na Biblioteca de Classes .NET, utilize o formato ClassName.MethodName(), em que o símbolo . é o operador de acesso de membro para aceder a um método definido na classe e os símbolos () são os operadores de invocação de método.
Ao chamar um método sem estado, não tem de criar uma nova instância da classe.
Ao chamar um método com estado, tem de criar uma instância da classe e aceder ao método no objeto.
Utilize o operador new para criar uma nova instância de uma classe.
Uma instância de uma classe é chamada objeto.
/\*

        Random dice = new();   >>>      Random dice = new Random();

         int roll = dice.Next(1, 7);
         Console.WriteLine(roll);


         The first version of the Next() method doesn't set an upper and lower boundary, so the method will return values ranging from 0 to 2,147,483,647, which is the maximum value an int can store.
        The second version of the Next() method specifies the maximum value as an upper boundary, so in this case, you can expect a random value between 0 and 100.
        The third version of the Next() method specifies both the minimum and maximum values, so in this case, you can expect a random value between 50 and 100.

        Random dice = new Random();
        int roll1 = dice.Next();
        int roll2 = dice.Next(101);
        int roll3 = dice.Next(50, 101);

        Console.WriteLine($@"First roll:
         {roll1}");
        Console.WriteLine($@"Second roll:
         {roll2}");
        Console.WriteLine($@"Third roll:
         {roll3}");

int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue,secondValue);

Console.WriteLine(largerValue);

        Random dice = new Random();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;
        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if (roll1 == roll2 || roll1 == roll3 || roll2 == roll3)
        {
            Console.WriteLine("You rolled doubles! +2 bonus to total!");
            total += 2;
        }
        if ((roll1 == roll2) && (roll2 == roll3))
        {
            Console.WriteLine("You rolled triples! +6 bonus to total!");
            total += 6;
        }
        Console.WriteLine($"Dice = {total}");

        if (total > 13)
        {
            Console.WriteLine("You win");
        }
        else
        {
            Console.WriteLine("You lose");
        }

        Random dice = new Random();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triples!  +6 bonus to total!");
                total += 6;
            }
            else
            {
                Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                total += 2;
            }
        }

        if (total >= 16)
        {
            Console.WriteLine("You win a new car!");
        }
        else if (total >= 10)
        {
            Console.WriteLine("You win a new laptop!");
        }
        else if (total == 7)
        {
            Console.WriteLine("You win a trip for two!");
        }
        else
        {
            Console.WriteLine("You win a kitten!");
        }
        Random random = new Random();
        int daysUntilExpiration = random.Next(12);
        int discountPercentage = 0;

        Console.WriteLine(daysUntilExpiration);

        if (daysUntilExpiration <= 1)
        {
            Console.WriteLine(@"Your subscription expires within a day!

Renew now and save 20%!");
discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
Console.WriteLine($@"Your subscription expires in {daysUntilExpiration} days.
Renew now and save 10%!");
discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
Console.WriteLine(@"Your subscription will expire soon. Renew now!");
}
else if (daysUntilExpiration == 0)
{
Console.WriteLine(@"Your subscription has expired.");
}
else
{
Console.WriteLine();
}
\*/

        /*  //    // string[] fraudulentOrderIDs = new string[3];
            string[] fraudulentOrderIDs = { "A123", "B456", "C789" };


             fraudulentOrderIDs[0] = "A123";
             fraudulentOrderIDs[1] = "B456";
             fraudulentOrderIDs[2] = "C789";
             // fraudulentOrderIDs[3] = "D000";

             Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
             Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
             Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
             Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

      */
        /*  Recap

Here's the most important things to remember when working with arrays:
An array is a special variable that holds a sequence of related data elements.
You should memorize the basic format of an array variable declaration.
Access each element of an array to set or get its values using a zero-based index inside of square brackets.
If you attempt to access an index outside of the boundary of the array, you get a run time exception.
The Length property gives you a programmatic way to determine the number of elements in an array.
_/
/_ int[] inventory = { 200, 450, 700, 175, 250 };
\*/

        /* int sum = 0;
        int bin = 0;
        foreach (int items in inventory)
        {
            sum += items;
            bin++;
            Console.WriteLine($"In  Bin {bin} we have  = {items} items (Running total: {sum})");
        }
        Console.WriteLine($"We have {sum} items in inventory.");

        string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

        foreach (string orderID in orderIDs)
        {
            if (orderID.StartsWith("B"))
            {
                Console.WriteLine(orderID);
            }
        }

        string[] iDList =
        {
            "B123",
            "C234",
            "A345",
            "C15",
            "B177",
            "G3003",
            "C235",
            "B179"
        };
        foreach (string iD in iDList)
        {
            if (iD.StartsWith("B"))
            {
                Console.WriteLine(iD);
            }
        }*/
