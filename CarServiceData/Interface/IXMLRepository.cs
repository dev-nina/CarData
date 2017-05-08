using CarServiceData.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceData.Interface
{
    public interface IXMLRepository
    {
        List<CarServiceViewModel> GetList();
    }
}
