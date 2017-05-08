using CarServiceData.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;


namespace CarServiceData.Models
{
    public class XMLReading : IXMLRepository
    {
        public List<CarServiceViewModel> GetList()
        {
            XDocument xDoc = XDocument.Load(Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString() + "\\CarServiceData\\DataFile\\AutoServiceData.xml");
            
            XElement xRoot = xDoc.Element("Orders");

            List<CarServiceViewModel> result = new List<CarServiceViewModel>();

            var readfile = from Order in xRoot.Elements("Order")
                           select new
                         {
                             Id = (int)Order.Attribute("OrderId"),
                             Title = (string)Order.Attribute("WorkName"),
                             BeginTime = (string)Order.Attribute("BeginTime"),
                             EndTime = (string)Order.Attribute("EndTime"),
                             Cost = (float)Order.Attribute("Cost"),
                             Mark = (string)Order.Element("Auto").Attribute("Mark"),
                             Model = (string)Order.Element("Auto").Attribute("Model"),
                             Year = (int)Order.Element("Auto").Attribute("Year"),
                             Transmission = (string)Order.Element("Auto").Attribute("Transmission"),
                             Horsepower = (float)Order.Element("Auto").Attribute("Horsepower"),
                             FirstName = (string)Order.Element("Client").Attribute("FirstName"),
                             SecondName = (string)Order.Element("Client").Attribute("SecondName"),
                             ThirdName = (string)Order.Element("Client").Attribute("ThirdName"),
                             Birth = (int)Order.Element("Client").Attribute("Birth"),
                             Phone = (string)Order.Element("Client").Attribute("Phone")
                         };
            foreach (var select in readfile)
            {
                try
                {
                    CarServiceViewModel element = new CarServiceViewModel(select.Id, select.Title, select.BeginTime.ToString(), select.EndTime.ToString(), select.Cost,
                                                                 select.Mark, select.Model, select.Year, select.Transmission, select.Horsepower,
                                                                 select.FirstName, select.SecondName, select.ThirdName, select.Birth, select.Phone);
                    result.Add(element);
                }
                //EndTime не определено
                catch
                {
                    CarServiceViewModel element = new CarServiceViewModel(select.Id, select.Title, select.BeginTime.ToString(), select.Cost,
                                                                select.Mark, select.Model, select.Year, select.Transmission, select.Horsepower,
                                                                select.FirstName, select.SecondName, select.ThirdName, select.Birth, select.Phone);
                    result.Add(element);
                }
            }
            return result;
        }
    }
    }
