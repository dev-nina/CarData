using CarServiceData.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections.ObjectModel;

namespace CarServiceData.Models
{
    public class BinaryReading : IBinaryRepository
    {
        // создаем объект BinaryFormatter
        public static BinaryFormatter formatter = new BinaryFormatter();

        List<client> Clients = new List<client>()
        {
            new client {IdClient = 1, FirstName = "Бородин", SecondName = "Вячеслав", ThirdName="Анатольевич", Birth = 1975, Phone = "89552854719" },
            new client {IdClient = 2, FirstName = "Володин", SecondName = "Ярослав", ThirdName="Вячеславович", Birth = 1986, Phone = "89526587419" },
            new client {IdClient = 3, FirstName = "Локтева", SecondName = "Светлана", ThirdName="Михайловна", Birth = 1990, Phone = "89525847693" },
            new client {IdClient = 4, FirstName = "Симонова", SecondName="Мария", ThirdName="Леонидовна", Birth=1990, Phone="89514589632" },
            new client {IdClient = 5, FirstName = "Беспалов", SecondName="Аркадий", ThirdName="Викторович", Birth=1974, Phone="89523647895" },
            new client {IdClient = 6, FirstName="Комарова", SecondName="Ирина", ThirdName="Дмитриевна", Birth=1990, Phone="89065214785" },
            new client {IdClient = 7, FirstName="Самохвалов", SecondName="Борис", ThirdName="Валентинович", Birth=1988, Phone="89068521475" },
            new client {IdClient = 8, FirstName="Жигалин", SecondName="Олег", ThirdName="Александрович", Birth=1968, Phone="89047458961" },
            new client {IdClient = 9, FirstName="Сорокина", SecondName="Светлана", ThirdName="Алексеевна", Birth=1977, Phone="89035478596" },
            new client {IdClient = 10, FirstName="Назаров", SecondName="Виталий", ThirdName="Иванович", Birth=1976, Phone="89095874697" },
            new client {IdClient = 11, FirstName="Семинихин", SecondName="Андрей" ,ThirdName="Игоревич", Birth=1975, Phone="89523647895"},
            new client {IdClient = 12, FirstName="Дементьева", SecondName="Марианна", ThirdName="Максимовна", Birth=1988, Phone="89075214896" },
            new client {IdClient = 13, FirstName="Потапов", SecondName="Евгений", ThirdName="Андреевич", Birth=1992, Phone="89095887412"},
            new client {IdClient = 14, FirstName="Торохин", SecondName="Петр", ThirdName="Сергеевич", Birth=1986, Phone="890561478596" },
            new client {IdClient = 15, FirstName="Евсюков", SecondName="Владислав", ThirdName="Аркадьевич", Birth=1971, Phone="89514589632"},
            new client {IdClient = 16, FirstName="Хамонов", SecondName="Леонид", ThirdName="Витальевич", Birth=1988, Phone="89525478259" },
            new client {IdClient = 17, FirstName="Торопыгин", SecondName="Станислав", ThirdName="Игоревич", Birth=1980, Phone="89051234785"},
            new client {IdClient = 18, FirstName="Комарова", SecondName="Ирина", ThirdName="Дмитриевна", Birth=1990, Phone="89065214785" },
            new client {IdClient = 19, FirstName="Леонов", SecondName="Михаил", ThirdName="Петрович", Birth=1995, Phone="89058741596" },
            new client {IdClient = 20, FirstName="Авилов", SecondName="Константин", ThirdName="Константинович", Birth=1978, Phone="89065214789" },
            new client {IdClient = 21, FirstName="Романова", SecondName="Елена", ThirdName="Леонидовна", Birth=1990, Phone="89514589632" },
            new client {IdClient = 22, FirstName="Дроздов", SecondName="Егор", ThirdName="Петрович", Birth=1988, Phone="89523647895" },
            new client {IdClient = 23, FirstName="Климов", SecondName="Анатолий", ThirdName="Евгеньевич", Birth=1975, Phone="89005278964" },
            new client {IdClient = 24, FirstName = "Лопатин", SecondName = "Ярослав", ThirdName="Вячеславович", Birth = 1986, Phone = "89526587419" },
            new client {IdClient = 25, FirstName = "Петров", SecondName = "Максим", ThirdName="Михайлович", Birth = 1990, Phone = "89525847693" },
            new client {IdClient = 26, FirstName = "Малкин", SecondName = "Игорь", ThirdName="Анатольевич", Birth = 1975, Phone = "89552854782" },
            new client {IdClient = 27, FirstName = "Лискин", SecondName = "Александр", ThirdName="Петрович", Birth = 1986, Phone = "89006587419" },
            new client {IdClient = 28, FirstName = "Тернов", SecondName = "Сергей", ThirdName="Иванович", Birth = 1990, Phone = "89055847693" },
            new client {IdClient = 29, FirstName = "Дроздов", SecondName = "Борис", ThirdName="Михайловна", Birth = 1990, Phone = "89065847693" },
            new client {IdClient = 30, FirstName = "Волков", SecondName = "Вячеслав", ThirdName="Анатольевич", Birth = 1975, Phone = "89552854719" }
        };

        List<car> Cars = new List<car>()
        {
            new car {IdCar = 1, Mark = "Audi", Model = "А6", Year = 1999, Transmission="Механическая", Horsepower = (float)2.6, ClientId = 1 },
            new car {IdCar = 2, Mark = "LADA", Model = "Granta", Year = 2012, Transmission="Автоматическая", Horsepower = (float)1.6, ClientId = 2 },
            new car {IdCar = 3, Mark = "Ford", Model = "Focus", Year = 2014, Transmission="Механическая", Horsepower = (float)1.8, ClientId = 3 },
            new car {IdCar = 4, Mark="Hyundai", Model ="Solaris", Year = 1998, Transmission="Автоматическая", Horsepower = (float)2.6, ClientId = 4 },
            new car {IdCar = 5, Mark="Hyundai", Model ="Elantra",  Year=2009, Transmission="Механическая", Horsepower = (float)1.6, ClientId = 5 },
            new car {IdCar = 6, Mark="Volkswagen", Model ="Tiguan",  Year=2017, Transmission="Автоматическая", Horsepower = (float)5.7, ClientId = 6 },
            new car {IdCar = 7, Mark="KIA", Model ="Rio", Year = 1998, Transmission="Автоматическая", Horsepower = (float)1.6, ClientId = 7 },
            new car {IdCar = 8, Mark="Lada", Model ="Kalina",  Year=2001,  Transmission="Автоматическая", Horsepower = (float)1.5, ClientId = 8 },
            new car {IdCar = 9, Mark="Lada", Model ="Largus" , Year = 2014, Transmission="Автоматическая", Horsepower = (float)2.8, ClientId = 9 },
            new car {IdCar = 10, Mark="Renault", Model ="Logan", Year = 2003, Transmission="Автоматическая", Horsepower = (float)3.6, ClientId = 10 },
            new car {IdCar = 11, Mark="Lada", Model ="Priora", Year = 2012, Transmission="Механическая", Horsepower = (float)1.6, ClientId = 11 },
            new car {IdCar = 12, Mark="Ford", Model ="Focus", Year = 2011, Transmission="Автоматическая", Horsepower = (float)2.8, ClientId = 12 },
            new car {IdCar = 13, Mark="Toyota", Model ="Corolla", Year = 2005, Transmission="Автоматическая", Horsepower = (float)1.6, ClientId = 1 },
            new car {IdCar = 14, Mark="Volkswagen", Model ="Golf", Year = 2012, Transmission="Автоматическая", Horsepower = (float)1.8, ClientId = 12 },
            new car {IdCar = 15, Mark="Land Rover", Model ="Discovery", Year = 2011, Transmission="Автоматическая", Horsepower = (float)1.7, ClientId = 13 },
            new car {IdCar = 16, Mark="Ford", Model ="Kuga", Year = 1998, Transmission="Механическая", Horsepower = (float)2.6, ClientId = 14 },
            new car {IdCar = 17, Mark="Honda", Model ="CR-V", Year = 2014, Transmission="Механическая", Horsepower = (float)1.5, ClientId = 15 },
            new car {IdCar = 18, Mark="Toyotar", Model ="Camry", Year = 2011, Transmission="Автоматическая", Horsepower = (float)1.9, ClientId = 16 },
            new car {IdCar = 19, Mark="Chevrolet", Model ="Silverado", Year = 2008, Transmission="Автоматическая", Horsepower = (float)2.4, ClientId = 17 },
            new car {IdCar = 20, Mark="Hyundai", Model ="Elantra", Year = 2012, Transmission="Механическая", Horsepower = (float)1.8, ClientId = 18 },
            new car {IdCar = 21, Mark="Volkswagen", Model ="Lavida", Year = 2011, Transmission="Автоматическая", Horsepower = (float)1.8, ClientId = 19 },
            new car {IdCar = 22, Mark = "Audi", Model = "А6", Year = 1998, Transmission="Автоматическая", Horsepower = (float)2.6, ClientId = 20 },
            new car {IdCar = 23, Mark = "LADA", Model = "Granta", Year = 2014, Transmission="Механическая", Horsepower = (float)1.6, ClientId = 21 },
            new car {IdCar = 24, Mark = "Ford", Model = "Focus", Year = 2011, Transmission="Механическая", Horsepower = (float)3.8, ClientId = 22 },
            new car {IdCar = 25, Mark="Toyota", Model ="Corolla", Year = 2011, Transmission="Автоматическая", Horsepower = (float)1.8, ClientId = 23 },
            new car {IdCar = 26, Mark="Volkswagen", Model ="Golf", Year = 2008, Transmission="Механическая", Horsepower = (float)1.6, ClientId = 24 },
            new car {IdCar = 27, Mark="KIA", Model ="Rio", Year = 2012, Transmission="Механическая", Horsepower = (float)1.5, ClientId = 25 },
            new car {IdCar = 28, Mark="Hyundai", Model ="Elantra", Year = 2009, Transmission="Автоматическая", Horsepower = (float)1.8, ClientId = 26 },
            new car {IdCar = 29, Mark="Ford", Model ="Mondeo", Year = 1998, Transmission="Механическая", Horsepower = (float)2.5, ClientId = 27 },
            new car {IdCar = 30, Mark="Skoda", Model ="Octavia", Year = 2010, Transmission="Автоматическая", Horsepower = (float)1.4, ClientId = 15 },
            new car {IdCar = 31, Mark="Nissan", Model ="Almera", Year = 2011, Transmission="Механическая", Horsepower = (float)1.9, ClientId = 28 },
            new car {IdCar = 32, Mark = "Audi", Model = "А6", Year = 2009, Transmission="Механическая", Horsepower = (float)2.6, ClientId = 14 },
            new car {IdCar = 33, Mark="Mitsubishi", Model ="Outlander", Year = 2012, Transmission="Автоматическая", Horsepower = (float)1.5, ClientId = 29 },
            new car {IdCar = 34, Mark = "Ford", Model = "Focus", Year = 2011, Transmission="Автоматическая", Horsepower = (float)1.8, ClientId = 30 }
        };

        List<order> Orders = new List<order>()
        {
            new order {IdOrder = 1, Title="Замена сцепления", BeginTime = new DateTime(2017, 02, 15), EndTime = new DateTime(2017, 02, 17), CarId = 1, Cost = 2500 },
            new order {IdOrder = 2, Title="Установка сигнализаций", BeginTime = new DateTime(2017, 02, 18), EndTime = new DateTime(2017, 02, 20), CarId = 2, Cost = 1300 },
            new order {IdOrder = 3, Title="Диагностика и ремонт ходовой", BeginTime = new DateTime(2017, 02, 19), EndTime = new DateTime(2017, 02, 21), CarId = 3, Cost = 1800 },
            new order {IdOrder = 4, Title="Чистка дроссельной заслонки", BeginTime = new DateTime(2017, 02, 20), EndTime = new DateTime(2017, 02, 22), CarId = 5, Cost = 1500 },
            new order {IdOrder = 5, Title="Замена двери с переборкой", BeginTime = new DateTime(2017, 02, 23), EndTime = new DateTime(2017, 02, 25), CarId = 6, Cost = 2500 },
            new order {IdOrder = 6, Title="Замена тормозной жидкости", BeginTime = new DateTime(2017, 02, 24), EndTime = new DateTime(2017, 02, 27), CarId = 7, Cost = 2400 },
            new order {IdOrder = 7, Title="Установка переднего бампера", BeginTime = new DateTime(2017, 02, 26), EndTime = new DateTime(2017, 03, 01), CarId = 8, Cost = 4300 },
            new order {IdOrder = 8, Title="Замена воздушного фильтра", BeginTime = new DateTime(2017, 02, 27), EndTime = new DateTime(2017, 03, 02), CarId = 9, Cost = 2500 },
            new order {IdOrder = 9, Title="Замена стабилизатора", BeginTime = new DateTime(2017, 03, 03), EndTime = new DateTime(2017, 03, 05), CarId = 10, Cost = 5300 },
            new order {IdOrder = 10, Title="Диагностика ДВС", BeginTime = new DateTime(2017, 03, 04), EndTime = new DateTime(2017, 03, 06), CarId = 11, Cost = 1300 },
            new order {IdOrder = 11, Title="Замена термостата", BeginTime = new DateTime(2017, 03, 05), EndTime = new DateTime(2017, 03, 07), CarId = 12, Cost = 2100 },
            new order {IdOrder = 12, Title="Замена печки", BeginTime = new DateTime(2017, 03, 06), EndTime = new DateTime(2017, 03, 08), CarId = 13, Cost = 1300 },
            new order {IdOrder = 13, Title="Установка магнитофона", BeginTime = new DateTime(2017, 03, 08), EndTime = new DateTime(2017, 03, 09), CarId = 14, Cost = 1000 },
            new order {IdOrder = 14, Title="Замена лампочки", BeginTime = new DateTime(2017, 03, 08), EndTime = new DateTime(2017, 03, 11), CarId = 15, Cost = 1500 },
            new order {IdOrder = 15, Title="Переборка трамблера", BeginTime = new DateTime(2017, 03, 09), EndTime = new DateTime(2017, 03, 12), CarId = 16, Cost = 1700 },
            new order {IdOrder = 16, Title="Замена замка зажигания", BeginTime = new DateTime(2017, 03, 09), EndTime = new DateTime(2017, 03, 13), CarId = 17, Cost = 1900 },
            new order {IdOrder = 17, Title="Замена стартера", BeginTime = new DateTime(2017, 03, 10), EndTime = new DateTime(2017, 03, 16), CarId = 18, Cost = 2500 },
            new order {IdOrder = 18, Title="Диагностика ДВС", BeginTime = new DateTime(2017, 03, 10), EndTime = new DateTime(2017, 03, 15), CarId = 19, Cost = 2700 },
            new order {IdOrder = 19, Title="Замена педального узла", BeginTime = new DateTime(2017, 03, 18), EndTime = new DateTime(2017, 03, 20), CarId = 20, Cost = 1600 },
            new order {IdOrder = 20, Title="Регулировка троса ручного тормоза", BeginTime = new DateTime(2017, 03, 19), EndTime = new DateTime(2017, 03, 22), CarId = 21, Cost = 3100 },
            new order {IdOrder = 21, Title="Замена задних колодок", BeginTime = new DateTime(2017, 03, 20), EndTime = new DateTime(2017, 03, 23), CarId = 22, Cost = 1300 },
            new order {IdOrder = 22, Title="Замена троса сцепления", BeginTime = new DateTime(2017, 03, 20), EndTime = new DateTime(2017, 03, 24), CarId = 23, Cost = 5300 },
            new order {IdOrder = 23, Title="Замена салонного фильтра", BeginTime = new DateTime(2017, 03, 23), EndTime = new DateTime(2017, 03, 24), CarId = 24, Cost = 4300 },
            new order {IdOrder = 24, Title="Замена опоры двигателя", BeginTime = new DateTime(2017, 03, 23), EndTime = new DateTime(2017, 03, 28), CarId = 25, Cost = 2500 },
            new order {IdOrder = 25, Title="Замена помпы", BeginTime = new DateTime(2017, 03, 25), EndTime = new DateTime(2017, 03, 27), CarId = 26, Cost = 1300 },
            new order {IdOrder = 26, Title="Замена натяжителя цепи", BeginTime = new DateTime(2017, 03, 26), EndTime = new DateTime(2017, 03, 29), CarId = 27, Cost = 2500 },
            new order {IdOrder = 27, Title="Замена сцепления", BeginTime = new DateTime(2017, 03, 29), EndTime = new DateTime(2017, 04, 01), CarId = 28, Cost = 2700 },
            new order {IdOrder = 28, Title="Диагностика и ремонт ходовой", BeginTime = new DateTime(2017, 03, 30), EndTime = new DateTime(2017, 04, 01), CarId = 29, Cost = 2700 },
            new order {IdOrder = 29, Title="Установка сигнализаций", BeginTime = new DateTime(2017, 04, 01), EndTime = new DateTime(2017, 04, 03), CarId = 20, Cost = 1600 },
            new order {IdOrder = 30, Title="Чистка дроссельной заслонки", BeginTime = new DateTime(2017, 04, 04), EndTime = new DateTime(2017, 04, 05), CarId = 21, Cost = 3100 },
            new order {IdOrder = 31, Title="Замена ролика-натяжителя", BeginTime = new DateTime(2017, 04, 07), EndTime = new DateTime(2017, 04, 05), CarId = 12, Cost = 1300 },
            new order {IdOrder = 32, Title="Снятие и установка двигателя", BeginTime = new DateTime(2017, 04, 07), EndTime = new DateTime(2017, 04, 09), CarId = 13, Cost = 5300 },
            new order {IdOrder = 33, Title="Полировка кузова", BeginTime = new DateTime(2017, 04, 08), EndTime = new DateTime(2017, 04, 10), CarId = 17, Cost = 4300 },
            new order {IdOrder = 34, Title="Установка сигнализаций", BeginTime = new DateTime(2017, 04, 08), EndTime = new DateTime(2017, 04, 12), CarId = 5, Cost = 2500 },
            new order {IdOrder = 35, Title="Чистка дроссельной заслонки", BeginTime = new DateTime(2017, 04, 09), EndTime = new DateTime(2017, 04, 13), CarId = 4, Cost = 1300 },
            new order {IdOrder = 36, Title="Замена сцепления", BeginTime = new DateTime(2017, 04, 10), EndTime = new DateTime(2017, 04, 14), CarId = 1, Cost = 2500 },
            new order {IdOrder = 37, Title="Диагностика и ремонт ходовой", BeginTime = new DateTime(2017, 04, 10), EndTime = new DateTime(2017, 04, 15), CarId = 8, Cost = 2700 },
            new order {IdOrder = 38, Title="Ремонт тормозной системы", BeginTime = new DateTime(2017, 04, 13), EndTime = new DateTime(2017, 04, 16), CarId = 9, Cost = 2700 },
            new order {IdOrder = 39, Title="Работы по авто-электрике", BeginTime = new DateTime(2017, 04, 15), EndTime = new DateTime(2017, 04, 17), CarId = 20, Cost = 1600 },
            new order {IdOrder = 40, Title="Диагностика ДВС", BeginTime = new DateTime(2017, 04, 15), EndTime = new DateTime(2017, 04, 18), CarId = 21, Cost = 3100 },
            new order {IdOrder = 41, Title="Замена троса сцепления", BeginTime = new DateTime(2017, 04, 20), EndTime = new DateTime(2017, 04, 20), CarId = 22, Cost = 1300 },
            new order {IdOrder = 42, Title="Развал схождение", BeginTime = new DateTime(2017, 04, 20), EndTime = new DateTime(2017, 04, 24), CarId = 23, Cost = 5300 },
            new order {IdOrder = 43, Title="Замена салонного фильтра", BeginTime = new DateTime(2017, 04, 24), EndTime = new DateTime(2017, 04, 25), CarId = 14, Cost = 4300 },
            new order {IdOrder = 44, Title="Замена опоры двигателя", BeginTime = new DateTime(2017, 04, 24), EndTime = new DateTime(2017, 04, 26), CarId = 25, Cost = 2500 },
            new order {IdOrder = 45, Title="Диагностика ДВС", BeginTime = new DateTime(2017, 04, 26), EndTime = new DateTime(2017, 04, 28), CarId = 30, Cost = 1300 },
            new order {IdOrder = 46, Title="Ремонт радиатора", BeginTime = new DateTime(2017, 04, 26), EndTime = new DateTime(2017, 04, 28), CarId = 27, Cost = 2500 },
            new order {IdOrder = 47, Title="Диагностика ДВС", BeginTime = new DateTime(2017, 04, 29), EndTime = new DateTime(2017, 05, 01), CarId = 31, Cost = 2700 },
            new order {IdOrder = 48, Title="Развал схождение", BeginTime = new DateTime(2017, 05, 02), CarId = 32, Cost = 3000 },
            new order {IdOrder = 49, Title="Замена лампочки", BeginTime = new DateTime(2017, 05, 04), CarId = 33, Cost = 3000 },
            new order {IdOrder = 50, Title="Ремонт радиатора", BeginTime = new DateTime(2017, 05, 05), CarId = 34, Cost = 1000 },
        };

        public void CreateFile()
        {
            // объекты для сериализации
            object[] data = { Clients, Cars, Orders };
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString() + "\\CarServiceData\\Data\\AutoServiceData.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, data);
            }
        }

        public IEnumerable GetList()
        {
            List<client> Clients = new List<client>();
            List<car> Cars = new List<car>();
            List<order> Orders = new List<order>();

            using (FileStream fs = new FileStream(Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString() + "\\CarServiceData\\Data\\AutoServiceData.dat", FileMode.OpenOrCreate))
            {
                object[] data = (object[])formatter.Deserialize(fs);
                Clients = (List<client>)data[0];
                Cars = (List<car>)data[1];
                Orders = (List<order>)data[2];
            }



            var result = from Order in Orders
                         join Car in Cars on Order.CarId equals Car.IdCar
                         join Client in Clients on Car.ClientId equals Client.IdClient
                         select new
                         {
                             Id = Order.IdOrder,
                             Title = Order.Title,
                             BeginTime = Order.BeginTime,
                             EndTime = Order.EndTime,
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
            return result.ToList();
        }
    }
}
