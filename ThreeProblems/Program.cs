/*
 * Name:        Justin Williams
 * Course:      CSCI 1250, Section 002
 * Assignment:  Lab 06, Three Problems
 * Date:        October 21, 2026
 * Description: A menu that keeps running until the user quits, offering three
 *              independent exercises or all three at once. Each exercise
 *              practices decisions and one of the four loops.
 */

// Initial variables to be used throughout the program.
using System.Linq.Expressions;

int choice = 0;
int grade = 0;
int rollNumber = 1;
string rollAgain = "y";
int wins = 0;
Random rng = new Random(4000);

do
{
    // This first choice = 0 resets the selection so the user can pick a new one.
    choice = 0;

    // Prints out the options for the user to select.
    System.Console.WriteLine("\n=== CSCI 1250 Lab 06 ===");
    System.Console.WriteLine("1. The Grade Checker");
    System.Console.WriteLine("2. The Dice Table");
    System.Console.WriteLine("3. The Score Report");
    System.Console.WriteLine("4. All Three");
    System.Console.WriteLine("5. Quit");

    // Prompts the user for a selection.
    System.Console.Write("Choose 1 through 5: ");
    choice = Convert.ToInt32(Console.ReadLine());

    // While is used because we don't know the number of times a person is going to run through the options, and runs indefinitely until 5 is selected.
    while (choice > 5 || choice < 1)
    {
        System.Console.WriteLine("Choose a number from 1 to 5.");
        System.Console.Write("Choose 1 through 5: ");
        choice = Convert.ToInt32(Console.ReadLine());
    }

    if (choice == 1 || choice == 4)
    {
        // Exercise 1
        System.Console.WriteLine("\n=== Exercise 1: The Grade Checker ===");
        System.Console.Write("Score: ");
        grade = Convert.ToInt32(Console.ReadLine());
        
        // A while loop is also used here to continually prompt the user for a valid number if their input is not within bounds, just like the main menu.
        while (grade > 100 || grade < 0)
        {
            // Reprompts the user if the value is not valid. Asking for their input again here prevents an infinite loop, since otherwise it would just continually output "A score must be between 0 and 100" until the console is killed.
            System.Console.WriteLine("A score must be between 0 and 100.");
            System.Console.Write("Score: ");
            grade = Convert.ToInt32(Console.ReadLine());
        }

        // Calculates the grade if it is an accepted value. I used if and else/if here so I could have each range and cw nested on its own.
        if (grade < 60)
        {
            System.Console.WriteLine(grade.ToString() + " earns an F.");
        }
        else if (grade >= 60 && grade < 70)
        {
            System.Console.WriteLine(grade.ToString() + " earns a D.");
        }
        else if (grade >= 70 && grade < 80)
        {
            System.Console.WriteLine(grade.ToString() + " earns a C.");
        }
        else if (grade >= 80 && grade < 90)
        {
            System.Console.WriteLine(grade.ToString() + " earns a B.");
        }
        else if (grade >= 90 && grade < 101)
        {
            System.Console.WriteLine(grade.ToString() + " earns an A.");
        }
    }

    if (choice == 2 || choice == 4)
    {
        System.Console.WriteLine("\n=== Exercise 2: The Dice Table ===");

        // Same as before. A while loop here (line 95) will continue to generate rolls for the user as long as they keep responding with Y.
        // Additionally, the variables being set here allows us to re-enter the menu later on.
        rollAgain = "y";
        rollNumber = 1;
        wins = 0;

        while (rollAgain == "y")
        {
            // Exercise 2
            int roll1 = rng.Next(1,7);
            int roll2 = rng.Next(1,7);
            int total = roll1 + roll2;

            // Write is used here instead of WriteLine so I can check the result and print out anything special like snake eyes on the same line.
            System.Console.Write("Roll " + rollNumber.ToString() + ": " + roll1.ToString() + " and " + roll2.ToString() + ", total " + total.ToString() + ". ");
            if (roll1 == roll2 && total == 2)
            {
                System.Console.WriteLine("Snake eyes.");
            }
            else if (roll1 == roll2 && total != 2)
            {
                System.Console.WriteLine("Doubles!");
            }
            else if (total == 7 || total == 11)
            {
                System.Console.WriteLine("A winner.");
                wins++;
            }
            else
            {
                System.Console.WriteLine();
            }

            System.Console.Write("Roll again? (y/n) ");
            rollAgain = System.Console.ReadLine();

            // If the user responds with a yes, it iterates the count for the number of rolls. Otherwise (including n) it exits. Since rollAGain no longer equals y, it exits the while loop and moves on.
            if (rollAgain == "y")
            {
                rollNumber++;
            }
            else
            {
                System.Console.WriteLine("You rolled " + rollNumber.ToString() + " times and won " + wins.ToString() + ".");
            }
        }

        
    }

    if (choice == 3 || choice == 4)
    {
        // Exercise 3
        System.Console.WriteLine("\n=== Exercise 3: The Score Report ===");

        int[] scores = new int[5];

        // for i in range will iterate through the array, collecting user input for only the number of entries in the array, which we defined as 5 above.
        for (int i = 0; i < scores.Length; i++)
        {
            System.Console.Write("Score " + (i + 1).ToString() + ": ");
            scores[i] = Convert.ToInt32(Console.ReadLine());
        }

        System.Console.WriteLine();

        int totalScore = 0;
        int highestScore = scores[0];
        int passingCount = 0;

        // I use a for each loop here to iterate through each score in the array.
        foreach (int score in scores)
        {
            totalScore += score;

            if (score > highestScore)
            {
                highestScore = score;
            }

            if (score >= 60)
            {
                passingCount++;
            }
        }

        double averageScore = (double)totalScore / scores.Length;

        System.Console.WriteLine("Scores entered: " + scores.Length.ToString());
        System.Console.WriteLine("Total: " + totalScore.ToString());
        System.Console.WriteLine("Average: " + averageScore.ToString("F1"));
        System.Console.WriteLine("Highest: " + highestScore.ToString());
        System.Console.WriteLine("Passing: " + passingCount.ToString() + " of " + scores.Length.ToString());
    }

} while (choice != 5);

System.Console.WriteLine("\nGoodbye.");