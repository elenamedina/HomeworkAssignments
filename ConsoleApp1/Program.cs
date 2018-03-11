using System;
using System.Collections.Generic;
using System.Linq;

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
                Console.WriteLine("=========================");
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
                    Console.WriteLine("As the great Shakespeare once said, 'What's in a name'? May I please have yours?");
                    string name = Console.ReadLine();
                    Console.WriteLine("A(n) " + name + " by any other name would smell just as sweet!");
                    Console.WriteLine();
                    Console.WriteLine("Now, can you input a number so I can square it?");
                    int userNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(userNumber * userNumber);
                }
                else if (num == 2)
                {
                    Console.WriteLine("Let me show you how smart I am...");
                    Console.WriteLine("Please enter a whole number: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("And now give me another whole number:");
                    int b = Convert.ToInt32(Console.ReadLine());
                    if (a > b)
                    {
                        Console.WriteLine(a + " is larger than " + b);
                    }
                    else if (a == b)
                    {
                        Console.WriteLine(a + " is equal to " + b);
                    }
                    else if (a < b)
                    {
                        Console.WriteLine(a + " is smaller than " + b);
                    }
                    Console.WriteLine();
                    Console.WriteLine("I have an important question to ask you. Is the earth FLAT? Type 'Y' for Yes or 'N' for No");
                    string answer = Console.ReadLine();
                    if
                        (answer == "Y" || answer == "y")
                    {
                        Console.WriteLine("Get outta here, you flat-earther! I believe in SCIENCE!");
                        Console.WriteLine();
                        break;
                    }
                    else if (answer == "N" || answer == "n")
                    {
                        Console.WriteLine("Very Good! You can stay :) ");
                        Console.WriteLine();
                    }
                }
                else if (num == 3)
                {
                    Console.WriteLine("Please may I have a positive integer?");
                    int loop = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("You entered " + loop + "\n");
                    for (int i = 1; i <= loop; i++)
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine("Please type your favorite word");
                    string word = Console.ReadLine();
                    Console.WriteLine("You typed " + word + "\n");
                    for (int i = 1; i <= loop; i++)
                    {
                        Console.WriteLine(word);
                    }
                }
                else if (num == 4)
                {
                    Console.WriteLine("What are the first names of your 5 favorite people? [ex: Jake Alex Mary...]");
                    string friends = Console.ReadLine();
                    string[] entries = friends.Split(' ');
                    List<string> names = entries.ToList();
                    Console.WriteLine("Like the good ol' days of Myspace, Here are the names of your 'Top 5' Friends:" + "\n");
                    foreach (string value in names)
                    {
                        Console.WriteLine(value + "\n");
                    }
                    Console.WriteLine("My name is R90kGJJX. Did we just become best friends?! [Type 'y' for yes or 'n' for no]");
                    string friendly = Console.ReadLine();
                    if (friendly == "yup" || friendly == "y" || friendly == "Y")
                    {
                        Console.WriteLine("This is Awesome! Here's your new list!" + "\n");
                        names.Add("R90kGJJX");
                        foreach (string value in names)
                        {
                            Console.WriteLine(value);
                        }
                    }
                    else
                    {
                        Console.WriteLine("You're Loss, mang!");
                    }
                }
                else if (num == 5)
                {
                    Dictionary<string, string> slang =
                           new Dictionary<string, string>();
                    Console.WriteLine("I am old- what is the new 'hip' lingo these days?" + "\n Please enter a current slang word and its definition, separated by a comma: [type 'quit' to exit and print your dictionary" + "\n");
                    string entries = Console.ReadLine();
                    string[] inputs = entries.Split(',');
                    string key = inputs[0];
                    string value = inputs[1];
                    slang.TryAdd(key, value);
                    foreach (var pair in slang)
                    {
                        Console.WriteLine(pair);
                    }
                }                                 
                else if (num == 6)
                {
                    Console.WriteLine("Now Exiting Program....");
                }
            } while (num != 6);
        }
    }
}