using QLGARA.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGARA.DAO
{
    public class CarDAO
    {
        private static CarDAO instance;

        public static CarDAO Instance
        {
            get { if (instance == null) instance = new CarDAO(); return CarDAO.instance; }
            private set { CarDAO.instance = value; }
        }
        private CarDAO() { }
        public List<Car> GetListCar()
        {
            List<Car> list = new List<Car>();

            string query = "select * from Xe";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Car car = new Car(item);
                list.Add(car);
            }

            return list;
        }
    }
}
