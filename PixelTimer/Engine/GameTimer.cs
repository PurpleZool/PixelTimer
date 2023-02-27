using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Engine
{
    public class GameTimer
    {

        private MainCicles cicles;
        private System.Timers.Timer timer;
        private double currentDecimalHour;

        public int Days { get { return cicles.Days; } }
        public int Months { get { return cicles.Months; } }
        public int Years { get { return cicles.Years; } }
        public int TotalSeconds { get { return cicles.TotalSecondsLapsed; } }

        public double DecimalHour { get { return currentDecimalHour; } }

        public bool Running { get { return timer.Enabled; } }

        public GameTimer(int dayLapseInSeconds, int monthLapseInDays, int yearLapseInMonths) 
        {
            cicles = new MainCicles(dayLapseInSeconds, monthLapseInDays, yearLapseInMonths);
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnSecondChanged;
            timer.AutoReset = true;
        }

        public void StartTimer() 
        {
            timer.Enabled = true;
        }

        public void StopTimer() 
        {
            timer.Enabled = false;
        }

        private void OnSecondChanged(Object source,ElapsedEventArgs e) 
        {

             currentDecimalHour = cicles.AddSeconds(1);
        }




        private double GetCurrentDecimalYear() 
        {
            return cicles.GetCurrentDecimalYear();
        }

        public double GetRealMonth() 
        {
            return GetCurrentDecimalYear() * 12;
        }

        public int[] GameDateArray() 
        {
            int totalSeconds = (int)Math.Round(currentDecimalHour * 86400); // 86400 segundos en un día
            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;

            return new int[] { hours, minutes, seconds };

        }

        public string GameHourString() 
        {
            int[] currentArr = GameDateArray();
            return string.Format("{0}:{1}:{2}", currentArr[0], currentArr[1], currentArr[2]);
        }

        public string GameShortDateString() 
        {
            return string.Format("{0}/{1}/{2}", Days,Months,Years);
        }

        public string GameLongDateString()
        {
            return GameHourString() + "-" + GameShortDateString();
        }

        
        private DateTime CurrentGameDate() 
        {
            int[] currentArr = GameDateArray();
            return new DateTime(Years,Months,Days,currentArr[0],currentArr[1],currentArr[2]);
        }


    }
}
