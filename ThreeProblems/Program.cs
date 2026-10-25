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
int choice = 0;

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
    }

    if (choice == 2 || choice == 4)
    {
        // Exercise 2
    }

    if (choice == 3 || choice == 4)
    {
        // Exercise 3
    }

} while (choice != 5);

System.Console.WriteLine("\nGoodbye.");