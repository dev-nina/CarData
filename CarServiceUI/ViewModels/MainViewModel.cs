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
using CarServiceData.Models;

namespace CarServiceUI.ViewModels
{
    class MainViewModel: INotifyPropertyChanged
    {
        StandardKernel kernel = new StandardKernel(new CommonModule());

        public ObservableCollection<CarServiceViewModel> Data { get; set; }

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
        
        public MainViewModel()
        {
            LoadingTypes = new ObservableCollection<LoadingType>
            {
                new LoadingType {Name = "MySQL Data Base"},
                new LoadingType {Name = "XML file"},
                new LoadingType {Name = "Binary file"}
            };
            Data = new ObservableCollection<CarServiceViewModel>();
        }        

        private RelayCommand loading;
        public RelayCommand Loading
        {
            get
            {
                return loading ??
              (loading = new RelayCommand(obj =>
              {
                  List<CarServiceViewModel> values = new List<CarServiceViewModel>();
                  switch (SelectedType.Name)
                  {
                      case "MySQL Data Base":
                          values = kernel.Get<IDBRepository>().GetList();
                          break;
                      case "XML file":
                          values = kernel.Get<IXMLRepository>().GetList();
                          break;
                      case "Binary file":
                          values = kernel.Get<IBinaryRepository>().GetList();
                          break;
                  }
                  Data.Clear();
                  foreach(CarServiceViewModel value in values)
                  {
                      Data.Add(value);
                  }
               
              }));

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
