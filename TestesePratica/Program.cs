using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        /* 
       

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
        */
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
        // Your code goes here
    }
}