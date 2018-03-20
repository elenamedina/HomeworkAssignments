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
            while(true)
            do               
            {
                Menu();
                    if (Int32.TryParse(Console.ReadLine(), out num))
                        switch (num)
                        {
                            case 1:
                                {
                                    Console.WriteLine("1. Inputs and Printing" + "\n");
                                    InputsAndPrinting();
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("2. Conditionals\n");
                                    Conditionals();
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("3. Looping\n");
                                    Looping();
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("4. Lists and Arrays\n");
                                    ListsAndArrays();
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine("5. Dictionaries\n");
                                    Dictionaries();
                                    break;
                                }
                            case 6:
                                {
                                    Console.WriteLine("6. Exit\n");
                                    Environment.Exit(0);
                                    break;

                                }
                        }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Oops! Try again!");
                    }    
            } while (num != 6);
        }

        public static void Menu()
        {
            Console.WriteLine("\n" + "Welcome to the Main Menu!\n");
            Console.WriteLine("1. Inputs and Printing");
            Console.WriteLine("2. Conditionals");
            Console.WriteLine("3. Looping");
            Console.WriteLine("4. Lists and Arrays");
            Console.WriteLine("5. Dictionaries");
            Console.WriteLine("6. Exit\n");
            Console.WriteLine("Please enter a valid Menu Option 1-5, or enter 6 to exit\n");
            Console.WriteLine("=========================");
        }

        public static void InputsAndPrinting()
        {
            Console.Clear();
            Console.WriteLine("As the great Shakespeare once said, 'What's in a name...'? May I please have yours?\n");
            string name = Console.ReadLine();
            Console.WriteLine("A(n) " + name + " by any other name would smell just as sweet!" + "\n");
            Console.WriteLine("Now, can you input a number so I can square it?\n");
            string userNumber = Console.ReadLine();            
            if (!Int32.TryParse(userNumber, out int value))
            {
                Console.WriteLine("Not a valid number. Please try again!");                
            }
            else
            {
                Console.WriteLine(value * value);
            }
            
        }

        public static void Conditionals()
        {
            Console.Clear();
            Console.WriteLine("Let me show you how smart I am...");
            Console.WriteLine("Please enter a whole number:");                      
            bool isWholeNumber = Int32.TryParse(Console.ReadLine(), out int a);
            while (!isWholeNumber)
            {
                Console.WriteLine("Not a valid number. Please try again!\n" + "Enter a whole number:");                
                isWholeNumber = Int32.TryParse(Console.ReadLine(), out a);
            }            

            Console.WriteLine("And now give me another whole number:");                    
            bool isWholeNumber2 = Int32.TryParse(Console.ReadLine(), out int b);
            while (!isWholeNumber2)
            {
                Console.WriteLine("Not a valid number. Please try again!\n" + "Enter a whole number:");               
                isWholeNumber2 = Int32.TryParse(Console.ReadLine(), out b);
            }

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
            Console.WriteLine("Now I have an important question to ask you. Is the earth FLAT? Type 'Y' for Yes or 'N' for No");
            string answer = Console.ReadLine();
            while (answer != "Y" && answer != "y" && answer != "N" && answer != "n")
            {
                Console.WriteLine("Is the earth FLAT ? Type 'Y' for Yes or 'N' for No");
                answer = Console.ReadLine();
            }

            if (answer == "Y" || answer == "y")
            {
                Console.WriteLine("Get outta here, you flat-earther! I believe in SCIENCE!");
                Console.WriteLine();
            }

            else if (answer == "N" || answer == "n")
            {
                Console.WriteLine("Very Good! You can stay :) ");
                Console.WriteLine();
            }
        }

        public static void Looping()
        {
            Console.Clear();
            Console.WriteLine("Please may I have a positive integer?");
            int loop;
            bool number = Int32.TryParse(Console.ReadLine(), out loop);
            while (!number)
            {
                Console.WriteLine("Not a valid number. Please try again!\n" + "Enter a whole number:");
                number = Int32.TryParse(Console.ReadLine(), out loop);
            }
            Console.WriteLine("You entered " + loop + "\n");
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i = i + 1;
            } while (i < (loop+1));

            Console.WriteLine("Please type your favorite word");
            string word = Console.ReadLine();
            Console.WriteLine("You typed " + word + "\n"); 
            for(i = 1; i <= loop; i++)
            {
                Console.WriteLine(word);
            }

        }

        public static void ListsAndArrays()
        {
            Console.Clear();
            Console.WriteLine("What are the first names of your 5 favorite people (separated by spaces)? [ex: John Alex Mary...]\n");
            string friends = Console.ReadLine();
            string[] entries = friends.Split(' ');
            List<string> names = entries.ToList();
            Console.WriteLine("Like the good ol' days of Myspace, Here are the names of your 'Top 5' Friends:\n");
            foreach (string value in names)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("My name is R90kGJJX. Did we just become best friends?! [Type 'y' for yes or 'n' for no]");
            string friendly = Console.ReadLine();
            if (friendly == "yup" || friendly == "y" || friendly == "Y")
            {
                Console.WriteLine("This is Awesome! Here's your new Friends list!\n");
                names.Add("R90kGJJX\n");
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

        public static void Dictionaries()
        {
            Console.Clear();
            Dictionary<string, string> slang = new Dictionary<string, string>();
            Console.WriteLine("I am old-- What is the new 'hip' lingo these days? Let's create a Dictionary! [type 'quit' to exit and print your dictionary");
            string stop;
            do
            {
                Console.WriteLine("Type your word and definition, separated by a comma");
                string entries = Console.ReadLine();
                stop = entries;
                if (entries == "quit")
                {
                    break;
                }
                string[] inputs = entries.Split(',');
                string key = inputs[0];
                string value = inputs[1];
                slang.TryAdd(key, value);
            } while (stop != "quit");
            Console.WriteLine("\n::Your 'Slang' Dictionary::\n");
            foreach (var pair in slang)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value + "\n");
            }
        }
    }
}