using CarServiceData.Interface;
using System.Collections.Generic;
using System.Linq;

namespace CarServiceData.Models
{
    public class DBReading: IDBRepository
    {
        private CarServiceEntities db = new CarServiceEntities();
        public List<CarServiceViewModel> GetList()
        {
           List<CarServiceViewModel> result = new List<CarServiceViewModel>();

            var request = from Order in db.Order
                          join Car in db.Car on Order.CarId equals Car.IdCar
                          join Client in db.Client on Car.ClientId equals Client.IdClient
                          select new
                          {
                              Id = Order.IdOrder,
                              Title = Order.Title,
                              BeginTime = Order.BeginTime,
                              EndTime = Order.EndTime,
                              Cost = Order.Cost,
                              Mark = Car.Mark,
                              Model = Car.Model,
                              Year = Car.Year,
                              Transmission = Car.Transmission,
                              Horsepower = Car.Horsepower,
                              FirstName = Client.FirstName,
                              SecondName = Client.SecondName,
                              ThirdName = Client.ThirdName,
                              Birth = Client.Birth,
                              Phone = Client.Phone
                          };
            
            var sortedList = request.OrderBy(i => i.Id);

            foreach (var select in sortedList)
            {
                try
                {
                    CarServiceViewModel element = new CarServiceViewModel(select.Id, select.Title, select.BeginTime.Date.ToString("dd.MM.yyyy"), select.EndTime.Value.Date.ToString("dd.MM.yyyy"), select.Cost,
                                                                 select.Mark, select.Model, select.Year, select.Transmission, select.Horsepower,
                                                                 select.FirstName, select.SecondName, select.ThirdName, select.Birth, select.Phone);
                    result.Add(element);
                }
                //EndTime не определено
                catch
                {
                    CarServiceViewModel element = new CarServiceViewModel(select.Id, select.Title, select.BeginTime.Date.ToString("dd.MM.yyyy"), select.Cost,
                                                                select.Mark, select.Model, select.Year, select.Transmission, select.Horsepower,
                                                                select.FirstName, select.SecondName, select.ThirdName, select.Birth, select.Phone);
                    result.Add(element);
                }
            }

            return result;
        }
    }
}

