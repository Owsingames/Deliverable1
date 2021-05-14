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
                string input = Console.ReadLine();

                //unit inches
                if (input.ToLower() == "inches")
                {
                    Console.Write("How many inches: ");
                    double inches = double.Parse(Console.ReadLine());

                    //conver inches to new unit
                    // 1 inch = 3.5 fidget spinners
                    double newValue = inches * 3.5;

                    Console.WriteLine("{0} inches = {1} fidget spinners", inches, newValue);
                    Console.WriteLine("");

                    Console.WriteLine("Would you like to convert another messurement? Yes or No");
                    string userAnswer = Console.ReadLine();
                    //end while loop if no
                    if (userAnswer.ToLower() == "yes" || userAnswer.ToLower() == "y")
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
                else if(input.ToLower() == "fidget spinners" || input.ToLower() == "fidgets" || input.ToLower() == "fidget")
                {
                    Console.Write("How many fidget spinners: ");
                    double fidgets = double.Parse(Console.ReadLine());


                    //convert fidget spinners to new unit
                    //3.5 fidgets = 1 inch
                    double newValue = fidgets / 3.5;

                    Console.WriteLine("{0} fidget spinners = {1} inches", fidgets, newValue);
                    Console.WriteLine("");

                    Console.WriteLine("Would you like to convert another messurement? Yes or No");
                    string userAnswer = Console.ReadLine();
                    //end while loop if no
                    if (userAnswer.ToLower() == "yes" || userAnswer.ToLower() == "y")
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
                else if (input.ToLower() == "feet")
                {
                    Console.Write("How many feet: ");
                    double feet = double.Parse(Console.ReadLine());

                    //conver feet to meme unit
                    //1 foot = 5 memes
                    double newValue = feet * 5;
                    Console.WriteLine("{0} feet = {1} memes", feet, newValue);

                    Console.WriteLine("Would you like to convert another messurement? Yes or No");
                    string userAnswer = Console.ReadLine();
                    //end while loop if no
                    if (userAnswer.ToLower() == "yes" || userAnswer.ToLower() == "y")
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
                else if(input.ToLower() == "meme" || input.ToLower() == "memes")
                {
                    Console.Write("How many memes: ");
                    double memes = double.Parse(Console.ReadLine());

                    //convert memes unit to feet
                    // 5 meme = 1 foot
                    double newValue = memes / 5;

                    Console.WriteLine("{0} memes = {1} feet", memes, newValue);

                    Console.WriteLine("Would you like to convert another messurement? Yes or No");
                    string userAnswer = Console.ReadLine();
                    //end while loop if no
                    if (userAnswer.ToLower() == "yes" || userAnswer.ToLower() == "y")
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
