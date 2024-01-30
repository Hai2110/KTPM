using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGARA.DTO;


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

        public static int CalendarWidth = 250;
        public static int CalendarHeight = 115;

        private CalendarDAO() { }

        public List<Calendar> LoadCalendarList()
        {
            List<Calendar> calendarList = new List<Calendar>();

            DataTable data = DataProvider.Instance.ExecuteQuery("Exec dbo.USP_GetCalendarList3");

            foreach (DataRow item in data.Rows)
            {
                Calendar calendar = new Calendar(item);
                calendarList.Add(calendar);
            }

            return calendarList;
        }
    }
}
