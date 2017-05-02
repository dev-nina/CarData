using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceData.Interface
{
    public interface IXMLRepository
    {
        IEnumerable GetList();
    }
}
