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
                Console.Write("Would you like to convert iches or feet: ");
                string input = Console.ReadLine();

                //if inches
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
                    if (userAnswer.ToLower() == "yes")
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
                //if feet
                else if (input.ToLower() == "feet")
                {
                    Console.Write("How many feet: ");
                    double feet = double.Parse(Console.ReadLine());

                    //conver feet to new unit
                    //1 foot = 5 memes
                    double newValue = feet * 5;
                    Console.WriteLine("{0} feet = {1} memes", feet, newValue);

                    Console.WriteLine("Would you like to convert another messurement? Yes or No");
                    string userAnswer = Console.ReadLine();
                    //end while loop if no
                    if (userAnswer.ToLower() == "yes")
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
                    Console.WriteLine("Please enter a inches or feet");
                    Console.Clear();
                }

            }
            
                
                

            
        }
    }
}
