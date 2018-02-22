using System;

namespace Assessments

{
    public class SimpleMenu
    {
        public static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to the Main Menu!");
                Console.WriteLine("1. Inputs and Printing");
                Console.WriteLine("2. Conditionals");
                Console.WriteLine("3. Looping");
                Console.WriteLine("4. Lists and Arrays");
                Console.WriteLine("5. Dictionaries");
                Console.WriteLine("6. Exit");
                Console.WriteLine();
                Console.WriteLine("Please Select an Option:");


                num = Convert.ToInt32(Console.ReadLine());
                if (num <= 0 || num >= 7)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a valid Menu Option 1-5, or enter 6 to exit");
                    Console.WriteLine();
                }
                else if (num == 1)
                {
                    Console.WriteLine("What's in a name? May I please have yours?");
                    string name = Console.ReadLine();
                    Console.WriteLine("A(n) " + name + " by any other name would smell just as sweet!");
                    Console.WriteLine("Now, can you input a number so I can square it?");
                    int userNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(userNumber * userNumber);
                }
                else if (num == 6)
                {
                    Console.WriteLine("Now Exiting Program");
                }
            } while (num != 6);
        }
    }
}