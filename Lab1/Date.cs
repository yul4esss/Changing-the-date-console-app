using System;

namespace Lab1
{
    class Date
    {
        private int day;
        private int month;
        private int year;

        public int Day { 
            get { return day;}
            set { 
                day = value; 
                if (value < 0 || value > 31) { throw new ArgumentOutOfRangeException(nameof(value), "Value must be between 0 and 31."); }
            }
        }

        public int Month { 
            get { return month; }
            set {
                month = value;
                if (value < 0 || value > 12) { throw new ArgumentOutOfRangeException(nameof(value), "Value must be between 0 and 12.");}
            }
        }

        public int Year {
            get { return year; }
            set {
                year = value;
                if (value < 0 || value > 2023) { throw new ArgumentOutOfRangeException(nameof(value), "Value must be between 0 and 2023.");}
            }
        }

        public Date() {}

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void ShowDate()
        {
            Console.WriteLine($"The date is: {(day < 10?"0"+day:day)}.{(month<10?"0"+month:month)}.{year}");
        }

        public int DayChange(int day)
        {
            this.day = day;
            ShowDate();
            return day;
        }

        public int MonthChange(int month)
        {
            this.month = month;
            ShowDate();
            return month;
        }

        public int YearChange(int year)
        {
            this.year = year;
            ShowDate();
            return year;
        }

    }
}