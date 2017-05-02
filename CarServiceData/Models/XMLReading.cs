using CarServiceData.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarServiceData.Models
{
    public class XMLReading : IXMLRepository
    {
        public IEnumerable GetList()
        {
            XDocument xDoc = XDocument.Load(Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString() + "\\CarServiceData\\Data\\AutoServiceData.xml");

            XElement xRoot = xDoc.Element("root");

            var result = from Order in xRoot.Elements("Orders")
                         select new
                         {
                             Id = (string)Order.Element("Order").Attribute("OrderId"),
                             Title = (string)Order.Element("Order").Attribute("WorkName"),
                             BeginTime = (string)Order.Element("Order").Attribute("BeginTime"),
                             EndTime = (string)Order.Element("Order").Attribute("EndTime"),
                             Cost = (string)Order.Element("Order").Attribute("Cost"),
                             Mark = (string)Order.Element("Order").Element("Auto").Attribute("Mark"),
                             Model = (string)Order.Element("Order").Element("Auto").Attribute("Model"),
                             Year = (string)Order.Element("Order").Element("Auto").Attribute("Year"),
                             Transmission = (string)Order.Element("Order").Element("Auto").Attribute("Transmission"),
                             Horsepower = (string)Order.Element("Order").Element("Auto").Attribute("Horsepower"),
                             FirstName = (string)Order.Element("Order").Element("Client").Attribute("FirstName"),
                             SecondName = (string)Order.Element("Order").Element("Client").Attribute("SecondName"),
                             ThirdName = (string)Order.Element("Order").Element("Client").Attribute("ThirdName"),
                             Birth = (string)Order.Element("Order").Element("Client").Attribute("Birth"),
                             Phone = (string)Order.Element("Order").Element("Client").Attribute("Phone")
                         };
            return result.ToList();
        }
    }
    }
