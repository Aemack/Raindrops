using System;
namespace PlingPlangPlong
{
    public class Program
    {
        // To see program run with de
        static void Main(string[] args)
        {
            bool validEntries = false;

            Console.WriteLine("Please enter a number for 'Pling'");
            string plingNumString = Console.ReadLine();
            Console.WriteLine("Please enter a number for 'Plang'");
            string plangNumString = Console.ReadLine();
            Console.WriteLine("Please enter a number for 'Plong'");
            string plongNumString = Console.ReadLine();

            Console.WriteLine("What number would you like to run up to?");
            string maxNumString = Console.ReadLine();

            validEntries = (
                int.TryParse(plingNumString, out int plingNum) &&
                int.TryParse(plangNumString, out int plangNum) &&
                int.TryParse(plongNumString, out int plongNum) &&
                int.TryParse(maxNumString, out int maxNum) 
                );
            if (!validEntries) return;
            PlingPlangPlongClass ppp = new PlingPlangPlongClass(int.Parse(plingNumString), int.Parse(plangNumString), int.Parse(plongNumString));

            Console.WriteLine("Number \t | \t Returned");
            for (int i = 0; i <= int.Parse(maxNumString); i++)
            {
                    Console.WriteLine(i + "\t | \t" + ppp.GetPlingPlangPlong(i));
            }
        }
    }
}
