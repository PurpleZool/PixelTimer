using System;

namespace Engine
{
    public class MainCicles
    {
        private int totalSeconds;
        private int secondCount;
        private int dayLapseInSeconds;
        private int gameDay;

        private int monthLapse;
        private int yearLapse;

        private int days;
        private int months;
        private int years;
        public int Days { get { return days; } private set { days = value; } }
        public int Months { get { return months; } private set { months = value; } }
        public int Years { get { return years; } private set { years = value; } }

        public int TotalSecondsLapsed { get { return totalSeconds; } }

        public MainCicles(int dayLapseInSeconds,int monthLapseInDays, int yearLapseInMonths)
        {
            this.dayLapseInSeconds = dayLapseInSeconds;
            this.monthLapse = monthLapseInDays;
            this.yearLapse = yearLapseInMonths;
            secondCount = Days = Months = Years = totalSeconds = 0 ;
        }

        public double AddSeconds( int seconds) 
        {
            this.secondCount += seconds;
            this.totalSeconds += seconds;
            CheckDates();
            return (double)secondCount / (double)dayLapseInSeconds;
        }

        private bool CheckDates() 
        {
            bool rechecked = false;
            if(secondCount > dayLapseInSeconds) 
            {
                secondCount = 1;
                days++;
                rechecked = true;
            }

            if(days > monthLapse) 
            {
                days = 1; 
                months++;
                rechecked = true;
            }

            if (months > monthLapse) 
            {
                months = 1;
                years++;
                rechecked = true;
            }

            return rechecked;
        }

        internal double GetCurrentDecimalYear()
        {
            return (double)(months / monthLapse);
        }

        public void AddDays(int days) 
        {
            this.days += days;
            CheckDates();
        }

        public void AddMonths(int months) 
        {
            this.months += months;
            CheckDates();
        }

    }
}
