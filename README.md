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

/_ /_
This C# console application is designed to:

- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
  - detects extra credit assignments based on the number of elements in the student's scores array.
  - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades:

Student Exam Score Overall Grade Extra Credit

Sophia 92.2 95.88 A 92 (3.68 pts)

\*/
int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

/\*
The outer foreach loop is used to:

- iterate through student names
- assign a student's grades to the studentScores array
- calculate exam and extra credit sums (inner foreach loop)
- calculate numeric and letter grade
- write the score report information
  \*/
  foreach (string name in studentNames)
  {
  string currentStudent = name;

      if (currentStudent == "Sophia")
          studentScores = sophiaScores;

      else if (currentStudent == "Andrew")
          studentScores = andrewScores;

      else if (currentStudent == "Emma")
          studentScores = emmaScores;

      else if (currentStudent == "Logan")
          studentScores = loganScores;

      int gradedAssignments = 0;
      int gradedExtraCreditAssignments = 0;

      int sumExamScores = 0;
      int sumExtraCreditScores = 0;

      decimal currentStudentGrade = 0;
      decimal currentStudentExamScore = 0;
      decimal currentStudentExtraCreditScore = 0;

      /*
      the inner foreach loop:
      - sums the exam and extra credit scores
      - counts the extra credit assignments
      */
      foreach (int score in studentScores)
      {
          gradedAssignments += 1;

          if (gradedAssignments <= examAssignments)
          {
              sumExamScores = sumExamScores + score;
          }

          else
          {
              gradedExtraCreditAssignments += 1;
              sumExtraCreditScores += score;
          }
      }

      currentStudentExamScore = (decimal)(sumExamScores) / examAssignments;
      currentStudentExtraCreditScore = (decimal)(sumExtraCreditScores) / gradedExtraCreditAssignments;

      currentStudentGrade = (decimal)((decimal)sumExamScores + ((decimal)sumExtraCreditScores / 10)) / examAssignments;

      if (currentStudentGrade >= 97)
          currentStudentLetterGrade = "A+";

      else if (currentStudentGrade >= 93)
          currentStudentLetterGrade = "A";

      else if (currentStudentGrade >= 90)
          currentStudentLetterGrade = "A-";

      else if (currentStudentGrade >= 87)
          currentStudentLetterGrade = "B+";

      else if (currentStudentGrade >= 83)
          currentStudentLetterGrade = "B";

      else if (currentStudentGrade >= 80)
          currentStudentLetterGrade = "B-";

      else if (currentStudentGrade >= 77)
          currentStudentLetterGrade = "C+";

      else if (currentStudentGrade >= 73)
          currentStudentLetterGrade = "C";

      else if (currentStudentGrade >= 70)
          currentStudentLetterGrade = "C-";

      else if (currentStudentGrade >= 67)
          currentStudentLetterGrade = "D+";

      else if (currentStudentGrade >= 63)
          currentStudentLetterGrade = "D";

      else if (currentStudentGrade >= 60)
          currentStudentLetterGrade = "D-";

      else
          currentStudentLetterGrade = "F";


      // Student         Exam Score      Overall Grade   Extra Credit
      // Sophia          92.2            95.88   A       92 (3.68 pts)

      Console.WriteLine($"{currentStudent}\t\t{currentStudentExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{currentStudentExtraCreditScore} ({(((decimal)sumExtraCreditScores / 10) / examAssignments)} pts)");

  }

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
\*/
// initialize variables - graded assignments
int examAssignments = 5;

        int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
        int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
        int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
        int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
        int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
        int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
        int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
        int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

        // Student names
        string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

        int[] studentScores = new int[10];

        string currentStudentLetterGrade = "";

        // Write the Report Header to the console
        Console.WriteLine("Student\t\tGrade\n");

        foreach (string name in studentNames)
        {
            string currentStudent = name;

            if (currentStudent == "Sophia")
                studentScores = sophiaScores;

            else if (currentStudent == "Andrew")
                studentScores = andrewScores;

            else if (currentStudent == "Emma")
                studentScores = emmaScores;

            else if (currentStudent == "Logan")
                studentScores = loganScores;

            else if (currentStudent == "Becky")
                studentScores = beckyScores;

            else if (currentStudent == "Chris")
                studentScores = chrisScores;

            else if (currentStudent == "Eric")
                studentScores = ericScores;

            else if (currentStudent == "Gregor")
                studentScores = gregorScores;

            else
                continue;


            // initialize/reset the sum of scored assignments
            int sumAssignmentScores = 0;

            // initialize/reset the calculated average of exam + extra credit scores
            decimal currentStudentGrade = 0;

            // initialize/reset a counter for the number of assignment
            int gradedAssignments = 0;

            // loop through the scores array and complete calculations for currentStudent
            foreach (int score in studentScores)
            {
                // increment the assignment counter
                gradedAssignments += 1;

                if (gradedAssignments <= examAssignments)
                    // add the exam score to the sum
                    sumAssignmentScores += score;

                else
                    // add the extra credit points to the sum - bonus points equal to 10% of an exam score
                    sumAssignmentScores += score / 10;
            }

            currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

            if (currentStudentGrade >= 97)
                currentStudentLetterGrade = "A+";

            else if (currentStudentGrade >= 93)
                currentStudentLetterGrade = "A";

            else if (currentStudentGrade >= 90)
                currentStudentLetterGrade = "A-";

            else if (currentStudentGrade >= 87)
                currentStudentLetterGrade = "B+";

            else if (currentStudentGrade >= 83)
                currentStudentLetterGrade = "B";

            else if (currentStudentGrade >= 80)
                currentStudentLetterGrade = "B-";

            else if (currentStudentGrade >= 77)
                currentStudentLetterGrade = "C+";

            else if (currentStudentGrade >= 73)
                currentStudentLetterGrade = "C";

            else if (currentStudentGrade >= 70)
                currentStudentLetterGrade = "C-";

            else if (currentStudentGrade >= 67)
                currentStudentLetterGrade = "D+";

            else if (currentStudentGrade >= 63)
                currentStudentLetterGrade = "D";

            else if (currentStudentGrade >= 60)
                currentStudentLetterGrade = "D-";

            else
                currentStudentLetterGrade = "F";

            //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
            Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
        }

        // required for running in VS Code (keeps the Output windows open to view results)
        Console.WriteLine("\n\rPress the Enter key to continue");
        Console.ReadLine();

/\* Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);
string value1 = "a";
string value2 = "A";

         Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());


        int saleAmount = 101;
        int discount = saleAmount > 1000 ? 100 : 50;
        Console.WriteLine($"Discount: {discount}");

        Random randomandomCoin = new Random();
       int coinFlip = randomandomCoin.Next(2);
       Console.WriteLine(randomandomCoin.Next(2));
       Console.WriteLine(coinFlip == 0 ? "Heads" : "Tails");
       Console.WriteLine(randomandomCoin.Next(2) == 0 ? "Heads" : "Tails");
        */
        /*     string permission = "Admin|Manager";
     int level = 53;

     if (permission.Contains("Admin"))
     {
         if (level > 55)
         {
             Console.WriteLine("Welcome, Super Admin user.");
         }
         else
         {
             Console.WriteLine("Welcome, Admin user.");
         }
     }
     else if (permission.Contains("Manager"))
     {
         if (level >= 20)
         {
             Console.WriteLine("Contact an Admin for access.");
         }
         else
         {
             Console.WriteLine("You do not have sufficient privileges.");
         }
     }
     else
     {
         Console.WriteLine("You do not have sufficient privileges.");
     }*/

        /* Console.WriteLine("Signed integral types:");

        Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
        Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
        Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
        Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

        Console.WriteLine("");
        Console.WriteLine("Unsigned integral types:");

        Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
        Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
        Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
        Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");


        int first = 2;
        string second = "4";
        int result = first + Convert.ToInt32(second);
        Console.WriteLine(result);
        */

/\* string[] values = { "12.3", "45", "ABC", "11", "DEF" };

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
         }

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

        /* string hello = "Hello";
        string world = "World";
        Console.WriteLine(string.Format("{0} ...............{1}!", hello, world));
        Console.WriteLine("{0} {0} {0} ", hello, world);

        decimal price = 123.45m;
        int discount = 50;
        Console.WriteLine($"Price: {price:C} (Save {discount:C})");

        int invoiceNumber = 1201;
        decimal productShares = 25.4568m;
        decimal subtotal = 2750.00m;
        decimal taxPercentage = .15825m;
        decimal total = 3185.19m;

        Console.WriteLine($"Invoice Number: {invoiceNumber}");
        Console.WriteLine($"   Shares: {productShares:N3} Product");
        Console.WriteLine($"     Sub Total: {subtotal:C}");
        Console.WriteLine($"           Tax: {taxPercentage:P2}");
        Console.WriteLine($"     Total Billed: {total:C}");

\*/

        /* string message = "Find what is (inside the parentheses)";

        int openingPosition = message.IndexOf('(');
        int closingPosition = message.IndexOf(')');

        Console.WriteLine(openingPosition);
        Console.WriteLine(closingPosition);

        int lenghtString = closingPosition - openingPosition;

        Console.WriteLine(message.Substring(openingPosition + 1, lenghtString)); */

        //string message = "What is the value <span>between the tags</span>?";

        //int openingPosition = message.IndexOf("<span>");
        //int closingPosition = message.IndexOf("</span>");

        /*  openingPosition += 6;
         int length = closingPosition - openingPosition;
         Console.WriteLine(message.Substring(openingPosition, length)); */
        /*  string message = "What is the value <span>between the tags</span>?";

         const string openSpan = "<span>";
         const string closeSpan = "</span>";

         int openingPosition = message.IndexOf(openSpan);
         int closingPosition = message.IndexOf(closeSpan);

         openingPosition += openSpan.Length;
         int length = closingPosition - openingPosition;
         Console.WriteLine(message.Substring(openingPosition, length)); */
        /*   string message = "(What if) I am (only interested) in the last (set of parentheses)?";

          int openingPar = message.LastIndexOf("(");
          int closingPar = message.LastIndexOf(")");

          openingPar += 1;

          Console.WriteLine(message.Substring(openingPar, closingPar - openingPar));

          string message = "(What if) there are (more than) one (set of parentheses)?";
          while (true)
          {
              int openingPosition = message.IndexOf('(');
              if (openingPosition == -1) break;

              openingPosition += 1;
              int closingPosition = message.IndexOf(')');
              int length = closingPosition - openingPosition;
              Console.WriteLine(message.Substring(openingPosition, length));

              // Note the overload of the Substring to return only the remaining
              // unprocessed message:
              message = message.Substring(closingPosition + 1);

        string data = "12345John Smith          5000  3  ";
        string updatedData = data.Remove(2, 20);
        Console.WriteLine(updatedData);
        data = data.Replace("3", "___");
        Console.WriteLine(data);

        const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

        string quantity = "";
        string output = "";

        // Your work here

        // Extract the "quantity"
        const string openSpan = "<span>";
        const string closeSpan = "</span>";

        int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
        int quantityEnd = input.IndexOf(closeSpan);
        int quantityLength = quantityEnd - quantityStart;
        quantity = input.Substring(quantityStart, quantityLength);
        quantity = $"Quantity: {quantity}";

        // Set output to input, replacing the trademark symbol with the registered trademark symbol
        const string tradeSymbol = "&trade;";
        const string regSymbol = "&reg;";
        output = input.Replace(tradeSymbol, regSymbol);

        // Remove the opening <div> tag
        const string openDiv = "<div>";
        int divStart = output.IndexOf(openDiv);
        output = output.Remove(divStart, openDiv.Length);

        // Remove the closing </div> tag and add "Output:" to the beginning
        const string closeDiv = "</div>";
        int divCloseStart = output.IndexOf(closeDiv);
        output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

        Console.WriteLine(quantity);
        Console.WriteLine(output);
                     */
                       // #1 the ourAnimals array will store the following:
        string animalSpecies = "";
        string animalID = "";
        string animalAge = "";
        string animalPhysicalDescription = "";
        string animalPersonalityDescription = "";
        string animalNickname = "";
        string suggestedDonation = "";

        // #2 variables that support data entry
        int maxPets = 8;
        string? readResult;
        string menuSelection = "";
        decimal decimalDonation = 0.00m;

        // #3 array used to store runtime data, there is no persisted data
        string[,] ourAnimals = new string[maxPets, 7];

        // #4 create sample data ourAnimals array entries
        for (int i = 0; i < maxPets; i++)
        {
            switch (i)
            {
                case 0:
                    animalSpecies = "dog";
                    animalID = "d1";
                    animalAge = "2";
                    animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
                    animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                    animalNickname = "lola";
                    suggestedDonation = "85.00";
                    break;

                case 1:
                    animalSpecies = "dog";
                    animalID = "d2";
                    animalAge = "9";
                    animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                    animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                    animalNickname = "gus";
                    suggestedDonation = "49.99";
                    break;

                case 2:
                    animalSpecies = "cat";
                    animalID = "c3";
                    animalAge = "1";
                    animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                    animalPersonalityDescription = "friendly";
                    animalNickname = "snow";
                    suggestedDonation = "40.00";
                    break;

                case 3:
                    animalSpecies = "cat";
                    animalID = "c4";
                    animalAge = "";
                    animalPhysicalDescription = "";
                    animalPersonalityDescription = "";
                    animalNickname = "lion";
                    suggestedDonation = "";

                    break;

                default:
                    animalSpecies = "";
                    animalID = "";
                    animalAge = "";
                    animalPhysicalDescription = "";
                    animalPersonalityDescription = "";
                    animalNickname = "";
                    suggestedDonation = "";
                    break;

            }

            ourAnimals[i, 0] = "ID #: " + animalID;
            ourAnimals[i, 1] = "Species: " + animalSpecies;
            ourAnimals[i, 2] = "Age: " + animalAge;
            ourAnimals[i, 3] = "Nickname: " + animalNickname;
            ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
            ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

            if (!decimal.TryParse(suggestedDonation, out decimalDonation))
            {
                decimalDonation = 45.00m; // if suggestedDonation NOT a number, default to 45.00
            }
            ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
        }

        // #5 display the top-level menu options
        do
        {
            // NOTE: the Console.Clear method is throwing an exception in debug sessions
            Console.Clear();

            Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
            Console.WriteLine(" 1. List all of our current pet information");
            Console.WriteLine(" 2. Display all dogs with a specified characteristic");
            Console.WriteLine();
            Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

            readResult = Console.ReadLine();
            if (readResult != null)
            {
                menuSelection = readResult.ToLower();
            }

            // use switch-case to process the selected menu option
            switch (menuSelection)
            {
                case "1":
                    // list all pet info
                    for (int i = 0; i < maxPets; i++)
                    {
                        if (ourAnimals[i, 0] != "ID #: ")
                        {
                            Console.WriteLine();
                            for (int j = 0; j < 7; j++)
                            {
                                Console.WriteLine(ourAnimals[i, j].ToString());
                            }
                        }
                    }
                    Console.WriteLine("\n\rPress the Enter key to continue");
                    readResult = Console.ReadLine();

                    break;

                case "2":
                    // Display all dogs with a specified characteristic");

                    string dogCharacteristic = "";

                    while (dogCharacteristic == "")
                    {
                        // have the user enter physical characteristics to search for
                        Console.WriteLine($"\nEnter one desired dog characteristics to search for");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            dogCharacteristic = readResult.ToLower().Trim();
                        }
                    }

                    bool noMatchesDog = true;
                    string dogDescription = "";

                    // #6 loop through the ourAnimals array to search for matching animals
                    for (int i = 0; i < maxPets; i++)
                    {
                        bool dogMatch = true;

                        if (ourAnimals[i, 1].Contains("dog"))
                        {

                            if (dogMatch == true)
                            {
                                // #7 Search combined descriptions and report results
                                dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];


                                if (dogDescription.Contains(dogCharacteristic))
                                {
                                    Console.WriteLine($"\nOur dog {ourAnimals[i, 3]} is a match!");
                                    Console.WriteLine(dogDescription);

                                    noMatchesDog = false;
                                }
                            }
                        }
                    }

                    if (noMatchesDog)
                    {
                        Console.WriteLine("None of our dogs are a match found for: " + dogCharacteristic);
                    }

                    Console.WriteLine("\n\rPress the Enter key to continue");
                    readResult = Console.ReadLine();

                    break;

                default:
                    break;
            }

        } while (menuSelection != "exit");



               /*  static void Numbers()
         {
             Random number = new Random();
             for (int count = 0; count < 7; count++)
             {
                 Console.WriteLine($"Random nuber = {number.Next(101)} ");
                 Console.WriteLine($"Count = {count}");
             }
         }
         Numbers();
          */

        /*
        if ipAddress consists of 4 numbers
        and
        if each ipAddress number has no leading zeroes
        and
        if each ipAddress number is in range 0 - 255

        then ipAddress is valid

        else ipAddress is invalid
        string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
        string[] address;
        bool validLength = false;
        bool validZeroes = false;
        bool validRange = false;

        foreach (string ip in ipv4Input)
        {
            address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

            ValidateLength();
            ValidateZeroes();
            ValidateRange();

            if (validLength && validZeroes && validRange)
            {
                Console.WriteLine($"{ip} is a valid IPv4 address");
            }
            else
            {
                Console.WriteLine($"{ip} is an invalid IPv4 address");
            }
        }

        void ValidateLength()
        {
            validLength = address.Length == 4;
        };

        void ValidateZeroes()
        {
            foreach (string number in address)
            {
                if (number.Length > 1 && number.StartsWith("0"))
                {
                    validZeroes = false;
                    return;
                }
            }

            validZeroes = true;
        }

        void ValidateRange()
        {
            foreach (string number in address)
            {
                int value = int.Parse(number);
                if (value < 0 || value > 255)
                {
                    validRange = false;
                    return;
                }
            }
            validRange = true;
        }
                */

/\* Random random = new Random();
int luck = random.Next(100);

         string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
         string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
         string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
         string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

         //Console.WriteLine("A fortune teller whispers the following words:");
         /* string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
         for (int i = 0; i < 4; i++)
         {
             Console.Write($"{text[i]} {fortune[i]} ");
         }

         void tellFortune()
         {
             Console.WriteLine("A fortune teller whispers the following words:");
             string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
             for (int i = 0; i < 4; i++)
             {
                 Console.Write($"{text[i]} {fortune[i]} ");
             }
         }
         tellFortune();
        string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };

        DisplayStudents(students);
        DisplayStudents(new string[] { "Robert", "Vanya" });

        void DisplayStudents(string[] students)
        {
            foreach (string student in students)
            {
                Console.Write($"{student}, ");
            }
            Console.WriteLine();
        }


        double pi = 3.14159;

        PrintCircleArea(12);
        PrintCircleCircumference(12);


        void PrintCircleArea(int radius)
        {
            double area = pi * (radius * radius);
            Console.WriteLine($"Area = {area}");
        }

        void PrintCircleCircumference(int radius)
        {
            double circumference = 2 * pi * radius;
            Console.WriteLine($"Circumference = {circumference}");
        }
        PrintCircleInfo(12);
        PrintCircleInfo(24);

        void PrintCircleInfo(int radius)
        {
            Console.WriteLine($"Circle with radius {radius}");
            PrintCircleArea(radius);
            PrintCircleCircumference(radius);
        }

        int a = 0;
        int b = 0;
        int c = 0;


        Console.WriteLine($"global statement: {a} x {b} = {c}");

        void Multiply(int a, int b, int c)
        {
            c = a * b;
            Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
        }

        Multiply(12, 4, 0);

        int[] array = { 1, 2, 3, 4, 5 };

        PrintArray(array);
        Clear(array);
        PrintArray(array);

        void PrintArray(int[] array)
        {
            foreach (int a in array)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine();
        }

        void Clear(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }




        string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
        string[] rsvps = new string[10];
        int count = 0;
        RSVP("Rebecca", 1, "none", true);
        RSVP("Nadia", 2, "Nuts", true);
        RSVP("Linh", 2, "none", false);
        RSVP("Tony", 1, "Jackfruit", true);
        RSVP("Noor", 4, "none", false);
        RSVP("Jonte", 2, "Stone fruit", false);
        ShowRSVPs();


        void RSVP(string name, int partySize, string allergies, bool inviteOnly)
        {

            if (inviteOnly)
            {
                bool found = false;
                foreach (string guest in guestList)
                {
                    if (guest.Equals(name))
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine($"Sorry, {name} is not on the guest list");
                    return;
                }

            }

        }

        void ShowRSVPs()
        {
            Console.WriteLine("\nTotal RSVPs:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(rsvps[i]);
            }
        }

        */
          /*   string[,] corporate =
           {
          {"Robert", "Bavin"}, {"Simon", "Bright"},{"Miguel","Monteiro"},
          {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
          {"Sarah", "Delucchi"}, {"Sinan", "Ali"}};

          string[,] external =
          {
          {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
          {"Shay", "Lawrence"}, {"Daren", "Valdes"}
      };

          string externalDomain = "hayworth.com";

          for (int i = 0; i < corporate.GetLength(0); i++)
          {
              DisplayEmail(first: corporate[i, 0], last: corporate[i, 1]);
          }

          for (int i = 0; i < external.GetLength(0); i++)
          {
              DisplayEmail(first: external[i, 0], last: external[i, 1], domain: externalDomain);
          }

          void DisplayEmail(string first, string last, string domain = "contoso.com")
          {
              string email = first.Substring(0, 2) + last;
              email = email.ToLower();
              Console.WriteLine($"{email}@{domain}");
          }
          Message(22, "miguel");
          void Message(int age, string name = "")
          {
              Console.WriteLine($"{name} , {age}");
          }

        double total = 0;
        double minimumSpend = 30.00;

        double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
        double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

        for (int i = 0; i < items.Length; i++)
        {
            total += GetDiscountedPrice(i);
        }

        total -= TotalMeetsMinimum() ? 5.00 : 0.00;

        Console.WriteLine($"Total: ${FormatDecimal(total)}");

        double GetDiscountedPrice(int itemIndex)
        {
            return items[itemIndex] * (1 - discounts[itemIndex]);
        }

        bool TotalMeetsMinimum()
        {
            return total >= minimumSpend;
        }

        string FormatDecimal(double input)
        {
            return input.ToString().Substring(0, 5);
        }
        double usd = 23.73;
        int vnd = UsdToVnd(usd);

        Console.WriteLine($"${usd} USD = ${vnd} VND");
        Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

        int UsdToVnd(double usd)
        {
            int rate = 23500;
            return (int)(rate * usd);
        }

        double VndToUsd(int vnd)
        {
            double rate = 23500;
            return vnd / rate;
        }


        string ReverseWord(string word)
        {
            string result = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                result += word[i];
            }
            return result;
        }
        string input = "Hipopotamus";

        Console.WriteLine(input);
        Console.WriteLine(ReverseWord(input));


        string ReverseSentence(string input)
        {
            string result = "";
            string[] words = input.Split(" ");

            foreach (string word in words)
            {
                result += ReverseWord(word) + " ";
            }

            return result.Trim();
        }
        string inputSentence = "Miguel is an hipopotamus";
        Console.WriteLine(inputSentence);
        System.Console.WriteLine(ReverseSentence(inputSentence));

        string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

        Console.WriteLine("Is it a palindrome?");
        foreach (string word in words)
        {
            Console.WriteLine($"{word}: {IsPalindrome(word)}");
        }


        bool IsPalindrome(string word)
        {
            int start = 0;
            int end = word.Length - 1;

            while (start < end)
            {
                if (word[start] != word[end])
                {
                    return false;
                }
                start++;
                end--;
            }

            return true;
        }

\*/
/\*
This code uses a names array and corresponding methods to display
greeting messages

string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };

string messageText = "";

foreach (string name in names)
{
if (name == "Sophia")
messageText = SophiaMessage();
else if (name == "Andrew")
messageText = AndrewMessage();
else if (name == "AllGreetings")
messageText = SophiaMessage();
messageText = messageText + "\n\r" + AndrewMessage();

    Console.WriteLine(messageText + "\n\r");

}

bool pauseCode = true;
while (pauseCode == true);

static string SophiaMessage()
{
return "Hello, my name is Sophia.";
}

static string AndrewMessage()
{
return "Hi, my name is Andrew. Good to meet you.";
}\*/

      /*   int[] numbers = new int[101]; // Create an array with size 101 (0 to 100)

        for (int i = 0; i <= 100; i++)
        {
            numbers[i] = i; // Assign the value of i to each element
        }
        for (int number = 0; number < numbers.Length; number++)
        {
            if (numbers[number] % 3 == 0)
            {
                System.Console.WriteLine($"{numbers[number]} -- Fizz");
            }
            else if (numbers[number] % 5 == 0)
            {
                System.Console.WriteLine($"{numbers[number]} -- Buzz");
            }
            else
            {
                continue;
            }
        } */
