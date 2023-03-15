using System;

namespace Lab1
{
    class Date
    {
        private int day;
        private int month;
        private int year;

        public int Day
        {
            get
            {
                return day;
            }
        }
        public int Month {
            get
            {
                return month;
            }
            set
            {
                month = value;
                if (value < 0 || value > 12)
                {
                    Console.WriteLine("The month can't be less than 0 or more than 12");
                    Environment.Exit(0);
                }
            }

            get
            {
                return year;
            }
            set
            {
                year = value;
                if (value < 0 || value > 2023)
                {
                    Console.WriteLine("The year can't be less than 0 or more than 2023");
                    Environment.Exit(0);
                }
            }
        }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void ShowDate()
        {
            if (day < 10 && month < 10)
                Console.WriteLine("The date is: 0{0}.0{1}.{2}", day, month, year);
            else if (day > 9 && month < 10)
            {
                Console.WriteLine("The date is: {0}.0{1}.{2}", day, month, year);
            }

        public void DayChange()
        {
            
            int newDay = 0;
            Console.WriteLine("Please, enter the day you want");
            try
            {
                newDay = Convert.ToInt32(Console.ReadLine());
                if (newDay < 0 || newDay > 31)
                {
                    Console.WriteLine("The value is not correct, please, try again");
                    Environment.Exit(0);
                }
            
            if (newDay < 10)
                Console.WriteLine("The new date is: 0{0}.0{1}.{2}", newDay, month, year);
            else if (newDay > 29 && month == 2)
                Console.WriteLine("It's February, it doesn't have more than 29 days XD");
            else
                Console.WriteLine("{0}.0{1}.{2}", newDay, month, year);

        }

        public void MonthChange()
        {
            Console.WriteLine("Please, enter the month you want");
            int newMonth = 0;

            try
            {
                newMonth = Convert.ToInt32(Console.ReadLine());
                if (newMonth < 0 || newMonth > 12)
                {
                    Console.WriteLine("Month value cannot be higher than 12");
                    Environment.Exit(0);

                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input type, please, try again");
                Environment.Exit(0);
            }

            if (day < 10 && newMonth < 10 )
                Console.WriteLine("The new date is: 0{0}.0{1}.{2}", day, newMonth, year);
            else if (day > 10 && newMonth < 10)
                Console.WriteLine("The new date is: {0}.0{1}.{2}", day, newMonth, year);
            else if (day < 10 && newMonth > 9 && newMonth < 13)
                Console.WriteLine("The new date is: 0{0}.{1}.{2}", day, newMonth, year);
            else if (day > 10 && newMonth > 9 && newMonth < 13)
                Console.WriteLine("The new date is: {0}.{1}.{2}", day, newMonth, year);
            else
                Console.WriteLine("Something went wrong");
        }

        public void YearChange()
        {

            int newYear = day;
            Console.WriteLine("Please, enter the year you want");
            try
            {
                newYear = Convert.ToInt32(Console.ReadLine());
                if (newYear < 0 || newYear > 2023)
                {
                    Console.WriteLine("Please, enter correct year. The value cannot be less than 0 or more than 2023");
                    Environment.Exit(0);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input type, please, try again");
                Environment.Exit(0);
            }

    }
}
