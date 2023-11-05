using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            string tempInputString;
            const int minTemp = -20;
            const int maxTemp = 130;
            bool valid;
            int temp = 0;
            const double STOP = 999;
            //prompt for temperature 
            Console.WriteLine("Enter temperatures from -20 to 130 (999 to stop)");
            //pull numerical value from input text
            int.TryParse(Console.ReadLine(), out int temperature);
            //test against desired range
            while (temperature != STOP) 
            {
                if (temperature < minTemp && temperature > maxTemp)
                {
                    Console.WriteLine("Valid temperatures range from -20 to 130. Please reenter temperature.");
                }
                else
                    //if the temperature is within the valid range and is an accepted input type, add it to the count of temperatures
                    //also calculate average of the entered temperatures
            }




        }
    }
}
