using Ninject.Modules;
using CarServiceData.Interface;
using CarServiceData.Models;

namespace CarServiceUI
{
    public class CommonModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDBRepository>().To<DBReading>();
            Bind<IXMLRepository>().To<XMLReading>();
            Bind<IBinaryRepository>().To<BinaryReading>();
        }
    }
}


