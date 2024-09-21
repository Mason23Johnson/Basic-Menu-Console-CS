using System;
using System.Threading;

class MainMenu
{
    public static void Main()
    {
        MainMenuScreen();
    }

    public static void MainMenuScreen()
    {
        Console.WriteLine($"\n\tWelcome!");
        Console.WriteLine("\t\t1. Example 1"); // User picks which menu they want
        Console.WriteLine("\t\t2. Example 2");
        Console.WriteLine("\t\t3. Example 3");
        Console.WriteLine("\t\t9. Settings");
        Console.WriteLine("\t\t10. Exit");

        try // try catch for numbers causing errors
        {
            int userInput = Convert.ToInt16(Console.ReadLine());

            switch (userInput) // Example #1 of methods being called based on user input
            {
                case 1:
                    Example1();
                    break;
                case 2:
                    Example2();
                    break;
                case 3:
                    Example3();
                    break;
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Coming soon!, Please enter a valid number.");
                    MainMenuScreen();
                    break;
                case 9:
                    Settings();
                    break;
                case 10:
                    ExitProgram();
                    break;
                default:
                    Console.WriteLine("Please enter a valid number.");
                    MainMenuScreen();
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            MainMenuScreen();
        }
    }

    public static void Example1() // Example place holders (templates for future)
    {
        Console.WriteLine("Example 1 Selected.");
        MainMenuScreen();
    }

    public static void Example2()
    {
        Console.WriteLine("Example 2 Selected.");
        MainMenuScreen();
    }

    public static void Example3()
    {
        Console.WriteLine("Example 3 Selected.");
        MainMenuScreen();
    }

    public static void Settings() // Place to have settings with template examples
    {
        Console.WriteLine("Please select one of the following.");
        Console.WriteLine("1. Example A");
        Console.WriteLine("2. Example B");

        int userInput = Convert.ToInt16(Console.ReadLine()); // Example #2 of methods being called based on user input
        if (userInput == 1)
        {
            ExampleA();
        }
        else if (userInput == 2)
        {
            ExampleB();
        }
        else
        {
            Console.WriteLine("Invalid selection.");
            Settings();
        }
    }

    public static void ExampleA()
    {
        Console.WriteLine("Example A Selected.");
        MainMenuScreen();
    }

    public static void ExampleB()
    {
        Console.WriteLine("Example B Selected.");
        MainMenuScreen();
    }

    public static void ExitProgram() // Gives a countdown until program closes
    {
        Console.WriteLine("Exiting the program.");
        Console.WriteLine("3");
        Thread.Sleep(1000);
        Console.WriteLine("2");
        Thread.Sleep(1000);
        Console.WriteLine("1");
        Thread.Sleep(1000);
        Environment.Exit(0);
    }
}
