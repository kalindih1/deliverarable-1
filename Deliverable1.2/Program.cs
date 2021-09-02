
using System;



class Program
{
    static void Main(string[] args)
    {
        string measurementType;
        float amount = 0;
        string response = "yes";


       





        while (response == "yes")
        {

            Console.WriteLine("Enter the measurement type:");
            measurementType = Console.ReadLine();
            Console.WriteLine("Enter an amount;");
            amount = float.Parse(Console.ReadLine());




            if (measurementType == "inches")
            {

                float inches, conversion, fidgetSpinners;
                conversion = 3.5f;
                inches = amount;
                fidgetSpinners = (amount * conversion);
                Console.WriteLine(fidgetSpinners + " fidget spinners ");


                Console.WriteLine("Would you like to do another conversion? ");
                response = Console.ReadLine();
            }
            else if (measurementType == "fidget spinners")
            {

                float inches, conversion, fidgetSpinners;
                conversion = 3.5f;
                fidgetSpinners = amount;
                inches = amount / conversion;
                Console.WriteLine(inches + " inches ");


                Console.WriteLine("Would you like to do another conversion? ");
                response = Console.ReadLine();
            }
            else if (measurementType == "feet")
            {

                float feet, conversion, memes;
                conversion = 5f;
                feet = amount;
                memes = amount * conversion;
                Console.WriteLine(memes + " memes ");


                Console.WriteLine("Would you like to do another conversion? ");
                response = Console.ReadLine();

            }
            else if (measurementType == "memes")
            {
                float feet, conversion, memes;
                conversion = 5f;
                memes = amount;
                feet = amount / conversion;
                Console.WriteLine(memes + " memes ");

                Console.WriteLine("Would you like to do another conversion? ");
                response = Console.ReadLine();

            }
            else 
            {
                Console.WriteLine("Good bye! ");
            }
        }

        
       

    }
}
