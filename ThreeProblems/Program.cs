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
    System.Console.WriteLine("5. Quit Program");

    // Prompts the user for a selection.
    System.Console.Write("Choose 1 through 5: ");
    choice = Convert.ToInt32(Console.ReadLine());

    // A while loop is used here to continually prompt the user for a valid number if their input is not within bounds.
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

        // Same as before. A while loop here will continue to generate rolls for the user as long as they keep responding with Y.
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
    }

} while (choice != 5);

System.Console.WriteLine("\nGoodbye.");