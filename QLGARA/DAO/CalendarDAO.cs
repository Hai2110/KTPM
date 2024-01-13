using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGARA.DAO
{
    public class CalendarDAO
    {
        private static CalendarDAO instance;

        public static CalendarDAO Instance
        {
            get { if (instance == null) instance = new CalendarDAO(); return CalendarDAO.instance; }
            private set { CalendarDAO.instance = value; }
        }

        public static int CalendarWidth = 100;
        public static int CalendarHeight = 100;

        private CalendarDAO() { }

        public List<Calendar> LoadCalendarList()
        {
            List<Calendar> calendarList = new List<Calendar>();
            DataCalendar data = DataProvider.Instance.ExecuteQuery("...");

            foreach (DataRow item in data.Rows)
            {
                Calendar calendar = new Calendar(item);
                calendarList.Add(calendar);
            }

            return calendarList;
        }
    }
}
