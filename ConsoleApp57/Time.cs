using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp57
{
    /// <summary>
    ///מחלקה המתארת זמן
    ///בפורמט של 24 שעות
    /// </summary>
    public class Time
    {
        
        private int hour;//שעה
        private int minute;//דקה
        private int second;//שניה

        #region C'tors
        public Time(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
        public Time(int hour, int minute)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = 0;

        }

        //Copy constructor
        public Time(Time hours)
        {
            this.hour=hours.hour;
            this.minute=hours.minute;
            this.second=hours.second;
        }
        #endregion

        #region Getters/Setters
        public int GetHour()
        {
            return hour;
        }

        public int GetMinute()
        {
            return minute;
        }
        public int GetSeconds()
        {
            return second;
        }

        public void SetSeconds(int seconds)
        {
            if (seconds >= 0 && seconds <= 60)
                this.second = seconds;
        }
        public void SetHour(int hours)
        {
            if (hours >= 0 && hours <= 23)
                this.hour = hours;
        }

        public void SetMinute(int minutes)
        {
            if (minutes >= 0 && minutes <= 60)
                this.minute = minutes;
        }

        #endregion

        #region פעולה מתארת
        public override string ToString()
        {
            return $"time: {hour}:{minute}:{second}";
        }
        #endregion

        #region פעולות נוספות

        /// <summary>
        /// פעולה הממירה את השעה למספר שניות כולל
        /// </summary>
        /// <returns>מספר שניות כולל</returns>
        public int TotalSeconds()
        {
            return this.hour * 3600 + this.minute * 60 + this.second;
        }

        /// <summary>
        /// פעולה המאפשרת להוסיף מספר שניות לשעה
        /// לדוגמה הוספת 3600 שניות = שעה אחת
        /// </summary>
        /// <param name="seconds">שניות להוספה</param>
        public void AddSeconds(int seconds)
        {
            int total = this.TotalSeconds();
            hour = ((total + seconds) / 3600) % 24;
            minute = ((total + seconds) / 60) % 60;
            second = (total + seconds) % 60;
        }

        /// <summary>
        /// פעולה המוסיפה שעות הוספת 24 שעות תחזיר לאותה שעה נוכחית
        /// </summary>
        /// <param name="hours">מספר שעות להוספה</param>
        public void AddHours(int hours)
        {
            this.AddSeconds(hours*3600);
        }

        /// <summary>
        /// פעולה המוסיפה דקות לשעה
        /// </summary>
        /// <param name="minutes"></param>
        public void AddMinutes(int minutes)
        {
            this.AddSeconds(minutes * 60);
        }
       
        /// <summary>
        /// פעולה המקבלת אובייקט זמן ומעדכנת את הזמן הנוכחי בהתאם
        /// </summary>
        /// <param name="t"></param>
        public void UpdateTime(Time t)
        {
            this.hour = t.hour;
            this.minute=t.minute;
            this.second = t.second;
        }

        #endregion
    }
}
