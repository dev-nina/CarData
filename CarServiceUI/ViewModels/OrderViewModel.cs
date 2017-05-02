using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using System.ComponentModel;
using CarServiceUI.Models;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using CarServiceData.Interface;
using System.Collections;
using System.Windows;
using CarServiceData;
using System.Data;

namespace CarServiceUI.ViewModels
{
    class OrderViewModel
    {
        StandardKernel kernel = new StandardKernel(new CommonModule());

        public IEnumerable Data;

        private LoadingType selectedType;
        public ObservableCollection<LoadingType> LoadingTypes { get; set; }
        public LoadingType SelectedType
        {
            get { return selectedType; }
            set
            {
                selectedType = value;
            }
        }

        public OrderViewModel()
        {
            LoadingTypes = new ObservableCollection<LoadingType>
            {
                new LoadingType {Name = "MySQL Data Base"},
                new LoadingType {Name = "XML file"},
                new LoadingType {Name = "Binary file"}
            };
        }        

        private RelayCommand loading;
        public RelayCommand Loading
        {

            get
            {
                return loading ??
              (loading = new RelayCommand(obj =>
              {
                  switch (SelectedType.Name)
                  {
                      case "MySQL Data Base":
                          this.Data = kernel.Get<IDBRepository>().GetList();
                          break;
                      case "XML file":
                          this.Data = kernel.Get<IXMLRepository>().GetList();
                          break;
                      case "Binary file":
                          this.Data = kernel.Get<IBinaryRepository>().GetList();
                          break;
                  }
              }));

            }
        }
    }
}
