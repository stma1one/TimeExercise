using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp57
{
    public class StudyDay
    {
        #region תכונות
        private string name;
        private Time hours;
        private string subject;
        #endregion

        #region  פעולות בונות
        ///פעולות
        #endregion

        #region Getter/Setters

        public string GetName()
            { return name; }
        public string GetSubject()
            { return subject; }
        public Time GetTime()
        {
            return new Time(hours);
        }

        public void SetName(string name)
        {
            this.name = name;

        }
        public void SetSubject(string subject)
        {
            this.subject = subject;
        }

        public void SetHour(Time t)
        {
            if(t.GetHour()>=8&&t.GetHour()<=16)
                this.hours=new Time(t);
            //another option without memory allocation
            // if(t.GetHour()>=8&&t.GetHour()<=16)
            //this.hours.UpdateTime(t);
        }
        #endregion

        #region ToString()
        #endregion
            


    }
}
