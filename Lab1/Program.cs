using System.Diagnostics;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;

            Date date = new Date();

            Console.WriteLine("Enter the day");
            date.Day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the month");
            date.Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the year");
            date.Year = Convert.ToInt32(Console.ReadLine());


            date.ShowDate();
            

            Console.WriteLine("Do you want to change the date?");
            Console.WriteLine("1 - YES");
            Console.WriteLine("2 - NO");
            Console.WriteLine("Please, input 1 or 2 number");
            
            
            try
            {
                userInput = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input type, please, try again");
            }

            if (userInput == 1)
            {
                Console.WriteLine("What do you want to change?");
                Console.WriteLine("Day - 1, Month - 2, Year - 3");

                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect input type, please, try again");
                }

                if(userInput == 1)
                {
                    date.DayChange();
                } else if (userInput == 2)
                {
                    date.MonthChange();
                } else if (userInput == 3)
                {
                    date.YearChange();
                }
                
                
            } else
            {
                Console.WriteLine("Thanks for using my program! See you soon <3");
                Environment.Exit(0);
            }

        }
    }
}