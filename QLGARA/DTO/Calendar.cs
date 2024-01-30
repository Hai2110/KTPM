using QLGARA.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGARA.DTO
{
    public class Calendar
    {
        public Calendar(int id, string thu)
        {
            this.ID = id;
            this.Thu = thu;
        }

        public Calendar(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Thu = row["thu"].ToString();
        }

        private string thu;

        public string Thu
        {
            get { return thu; }
            set { thu = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
