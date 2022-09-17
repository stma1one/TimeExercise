using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp57
{
    public class StudyDay
    {
        #region תכונות
        
        private Time[] hours;
        private string subject;
        private int current;
        #endregion

        #region  פעולות בונות
        ///פעולות
        public StudyDay(string subject, int hours)
        {
              
            this.subject= subject;
            this.hours=new Time[hours];
            this.current = 0;//כרגע אין אף שעה ביום
        }
        #endregion

        #region Getter/Setters

   
        public string GetSubject()
            { return subject; }
        public Time[] GetTime()
        {
            #region מחזירים את המקום בזיכרון... ולא עותק
            /*שינויים שיתבצעו בתוכנית הראשית ישנו את התכונה של האובייקט 
             * studyDay
             * 
             * return this.hours;
             */
            #endregion

            #region החזרת עותק. 
            //שינויים בתוכנית הראשית לא ישפיעו על האובייקט
            Time[] result=new Time[hours.Length];
            for (int i = 0; i < hours.Length; i++)
            {
                result[i] = new Time(hours[i]);
            }
            return result;
            #endregion
        }

        public void SetSubject(string subject)
        {
            this.subject = subject;
        }

        public void AddHour(Time t)
        {
            //נבדוק שיש מקום
            if (hours != null && current < hours.Length)
            { /*
             * שינויים שיעשו בתוכנית הראשית ל
             * this.hour[current++]=t;
             * ישפיעו על האובייקט שלנו
             * 
             */

                //יוצרים עותק של הזמן שנרצה להכניס
                //נכניס אותו למקום הבא הפנוי
                this.hours[current++] = new Time(t);
            }
        }
        #endregion

        #region ToString()
        public override string ToString()
        {
            //במערך לקבל תוכן- נצטרך לרוץ על התאים שלו
            //נרוץ עד current
            //כדי שנוכל להמנע מבדיקות תאים ריקים
            string str = $"{subject} hours:\n";
            for (int i = 0; i < current; i++)
            {
                str+=$"Day {i}: {hours[i]}";
            }
            return str;
        }
        #endregion

        public void ChangeTime(int hourInDay, Time t)
        {
            if (hourInDay >= 0 && hourInDay <= current && hours[hourInDay]!=null)
            hours[hourInDay] = new Time(t);
        }



    }
}
