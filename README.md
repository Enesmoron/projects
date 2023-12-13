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
