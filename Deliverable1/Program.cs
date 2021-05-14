using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deliverable 1
            Console.WriteLine("Grand Circus Deliverable 1");
            Console.WriteLine("Messurement Converter");
            Console.WriteLine("");

            while (true)
            {
                //ask for unit type
                Console.WriteLine("inches, feet, fidget spinners, or memes");
                Console.Write("Please select a unit to convert: ");
                string input = Console.ReadLine().ToLower();

                //unit inches
                if (input == "inches" || input == "inch")
                {
                    Console.Write("How many inches: ");
                    double inches = double.Parse(Console.ReadLine());

                    //conver inches to new unit
                    // 1 inch = 3.5 fidget spinners
                    double newValue = inches * 3.5;

                    Console.WriteLine("{0} inches = {1} fidget spinners", inches, newValue);
                    Console.WriteLine("");

                    Console.WriteLine("Would you like to convert another messurement? Yes or No");
                    string userAnswer = Console.ReadLine().ToLower();
                    //end while loop if no
                    if (userAnswer == "yes" || userAnswer == "y")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Goodbye");
                        break;
                    }
                    
                }
                //unit fidget spinner
                else if(input == "fidget spinners" || input == "fidgets" || input == "fidget")
                {
                    Console.Write("How many fidget spinners: ");
                    double fidgets = double.Parse(Console.ReadLine());


                    //convert fidget spinners to new unit
                    //3.5 fidgets = 1 inch
                    double newValue = fidgets / 3.5;

                    Console.WriteLine("{0} fidget spinners = {1} inches", fidgets, newValue);
                    Console.WriteLine("");

                    Console.WriteLine("Would you like to convert another messurement? Yes or No");
                    string userAnswer = Console.ReadLine().ToLower();
                    //end while loop if no
                    if (userAnswer == "yes" || userAnswer == "y")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Goodbye");
                        break;
                    }

                }
                //unit feet
                else if (input == "feet")
                {
                    Console.Write("How many feet: ");
                    double feet = double.Parse(Console.ReadLine());

                    //conver feet to meme unit
                    //1 foot = 5 memes
                    double newValue = feet * 5;
                    Console.WriteLine("{0} feet = {1} memes", feet, newValue);

                    Console.WriteLine("Would you like to convert another messurement? Yes or No");
                    string userAnswer = Console.ReadLine().ToLower();
                    //end while loop if no
                    if (userAnswer == "yes" || userAnswer == "y")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Goodbye");
                        break;
                    }
                }
                else if(input == "meme" || input == "memes")
                {
                    Console.Write("How many memes: ");
                    double memes = double.Parse(Console.ReadLine());

                    //convert memes unit to feet
                    // 5 meme = 1 foot
                    double newValue = memes / 5;

                    Console.WriteLine("{0} memes = {1} feet", memes, newValue);

                    Console.WriteLine("Would you like to convert another messurement? Yes or No");
                    string userAnswer = Console.ReadLine().ToLower();
                    //end while loop if no
                    if (userAnswer == "yes" || userAnswer == "y")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Goodbye");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid unti to convert: inches, fidget spinners, feet, or memes");
                    Console.Clear();
                }

            }
            
                
                

            
        }
    }
}
