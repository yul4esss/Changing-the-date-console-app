using System.Diagnostics;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;

            Date date = new Date();

            try
            {
                Console.WriteLine("Enter the day");
                date.Day = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the month");
                date.Month = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the year");
                date.Year = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception e) { throw new Exception("Format exception", e); }

            date.ShowDate(); 

            Console.WriteLine("Do you want to change the date?");
            Console.WriteLine("1 - YES");
            Console.WriteLine("2 - NO");
            Console.WriteLine("Please, input 1 or 2 number");
            
            try {userInput = Convert.ToInt32(Console.ReadLine());}
            catch (Exception e) { throw new Exception("Format exception", e); }

            if (userInput == 1)
            {
                Console.WriteLine("What do you want to change?");
                Console.WriteLine("Day - 1, Month - 2, Year - 3");

                try { userInput = Convert.ToInt32(Console.ReadLine());}
                catch (Exception e) { throw new Exception("Format exception", e); }

                if (userInput == 1)
                {
                    int newDay = 0;
                    Console.WriteLine("Enter the new day value");
                    try
                    {
                        newDay = Convert.ToInt32(Console.ReadLine());
                        if(newDay < 0 || newDay > 31) { throw new ArgumentOutOfRangeException(); }
                    }
                    catch (Exception e) { throw new Exception("Format exception", e); }

                    date.DayChange(newDay);
                } 
                else if (userInput == 2)
                {
                    int newMonth = 0;
                    Console.WriteLine("Enter the new month value");
                    try
                    {
                        newMonth = Convert.ToInt32(Console.ReadLine());
                        if (newMonth < 0 || newMonth > 12) { throw new ArgumentOutOfRangeException(); }
                    }
                    catch (Exception e) { throw new Exception("Format exception", e); }

                    date.MonthChange(newMonth);
                } 
                else if (userInput == 3)
                {
                    int newYear = 0;
                    Console.WriteLine("Enter the new year value");
                    try
                    {
                        newYear = Convert.ToInt32(Console.ReadLine());
                        if (newYear < 0 || newYear > 2023) { throw new ArgumentOutOfRangeException(); }
                    }
                    catch (Exception e) { throw new Exception("Format exception", e); }

                    date.YearChange(newYear);
                }  
            }
            else{Console.WriteLine("Thanks for using my program! See you soon <3");}

        }
    }
}