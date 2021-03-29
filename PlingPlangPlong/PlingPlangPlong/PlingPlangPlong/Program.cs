using System;
namespace PlingPlangPlong
{
    public class Program
    {
        // Run the program to demo the functionality of the PlingPlangPlong method
        static void Main(string[] args)
        {
            //Get input
            Console.WriteLine("Please enter a number for 'Pling'");
            string plingNumString = Console.ReadLine();
            Console.WriteLine("Please enter a number for 'Plang'");
            string plangNumString = Console.ReadLine();
            Console.WriteLine("Please enter a number for 'Plong'");
            string plongNumString = Console.ReadLine();

            Console.WriteLine("What number would you like to run up to?");
            string maxNumString = Console.ReadLine();

            //Checking to make sure input is a number
            int plingNum = 0, plangNum = 0, plongNum = 0, maxNum = 0;
            bool validEntries = false;
            validEntries = (
                int.TryParse(plingNumString, out plingNum) &&
                int.TryParse(plangNumString, out plangNum) &&
                int.TryParse(plongNumString, out plongNum) &&
                int.TryParse(maxNumString, out maxNum) 
                );

            if (!validEntries) return;
            
            // Create new Raindrops object with inputed numbers
            Raindrops rndrp = new Raindrops(plingNum, plangNum, plongNum);

            Console.WriteLine("Number \t | \t Returned");
            for (int i = 0; i <= maxNum; i++)
            {
                    Console.WriteLine(i + "\t | \t" + rndrp.GetPlingPlangPlong(i));
            }
        }
    }
}
