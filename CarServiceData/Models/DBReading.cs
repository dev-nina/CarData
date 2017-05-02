using CarServiceData.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CarServiceData.Models
{
    public class DBReading : IDBRepository
    {
        protected readonly DBModel db = new DBModel("server = localhost; user id = root; password=root;persistsecurityinfo=True;database=carservice;allowuservariables=True");

        public IEnumerable GetList()
        {
            return CreateList();
        }

        private IEnumerable CreateList()
        {
            var result = from Orders in db.Order
                         join Cars in db.Car on Orders.CarId equals Cars.IdCar
                         join Clients in db.Сlient on Cars.ClientId equals Clients.IdClient
                         select new
                         {
                             Id = Orders.IdOrder,
                             Title = Orders.Title,
                             BeginTime = Orders.BeginTime,
                             EndTime = Orders.EndTime,
                             Cost = Orders.Cost,
                             Mark = Cars.Mark,
                             Model = Cars.Model,
                             Year = Cars.Year,
                             Transmission = Cars.Transmission,
                             Horsepower = Cars.Horsepower,
                             FirstName = Clients.FirstName,
                             SecondName = Clients.SecondName,
                             ThirdName = Clients.ThirdName,
                             Birth = Clients.Birth,
                             Phone = Clients.Phone
                         };
            return result.ToList();
        }
    }
}

