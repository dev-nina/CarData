using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CarServiceData.Models
{
    public class CarServiceViewModel: INotifyPropertyChanged
    {
        private int id;
        private string title;
        private string beginTime;
        private string endTime;
        private float cost;
        private string mark;
        private string model;
        private int year;
        private string transmission;
        private float horsepower;
        private string firstName;
        private string secondName;
        private string thirdName;
        private int birth;
        private string phone;

        public CarServiceViewModel(int id, string title, string beginTime, string endTime, float cost, string mark, string model, int year, string transmission, float horsepower, string firstName, string secondName, string thirdName, int birth, string phone)
        {
            this.id = id;
            this.title = title;
            this.beginTime = beginTime;
            this.endTime = endTime;
            this.cost = cost;
            this.mark = mark;
            this.model = model;
            this.year = year;
            this.transmission = transmission;
            this.horsepower = horsepower;
            this.firstName = firstName;
            this.secondName = secondName;
            this.thirdName = thirdName;
            this.birth = birth;
            this.phone = phone;
        }

        public CarServiceViewModel(int id, string title, string beginTime, float cost, string mark, string model, int year, string transmission, float horsepower, string firstName, string secondName, string thirdName, int birth, string phone)
        {
            this.id = id;
            this.title = title;
            this.beginTime = beginTime;
            this.cost = cost;
            this.mark = mark;
            this.model = model;
            this.year = year;
            this.transmission = transmission;
            this.horsepower = horsepower;
            this.firstName = firstName;
            this.secondName = secondName;
            this.thirdName = thirdName;
            this.birth = birth;
            this.phone = phone;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        public string BeginTime
        {
            get
            {
                return beginTime;
            }

            set
            {
                beginTime = value;
                OnPropertyChanged("BeginTime");
            }
        }

        public string EndTime
        {
            get
            {
                return endTime;
            }

            set
            {
                endTime = value;
                OnPropertyChanged("EndTime");
            }
        }

        public float Cost
        {
            get
            {
                return cost;
            }

            set
            {
                cost = value;
                OnPropertyChanged("Cost");
            }
        }

        public string Mark
        {
            get
            {
                return mark;
            }

            set
            {
                mark = value;
                OnPropertyChanged("Mark");
            }
        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
                OnPropertyChanged("Model");
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
                OnPropertyChanged("Year");
            }
        }

        public string Transmission
        {
            get
            {
                return transmission;
            }

            set
            {
                transmission = value;
                OnPropertyChanged("Transmission");
            }
        }

        public float Horsepower
        {
            get
            {
                return horsepower;
            }

            set
            {
                horsepower = value;
                OnPropertyChanged("Horsepower");
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string SecondName
        {
            get
            {
                return secondName;
            }

            set
            {
                secondName = value;
                OnPropertyChanged("SecondName");
            }
        }

        public string ThirdName
        {
            get
            {
                return thirdName;
            }

            set
            {
                thirdName = value;
                OnPropertyChanged("ThirdName");
            }
        }

        public int Birth
        {
            get
            {
                return birth;
            }

            set
            {
                birth = value;
                OnPropertyChanged("Birth");
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
                OnPropertyChanged("Phone");
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
