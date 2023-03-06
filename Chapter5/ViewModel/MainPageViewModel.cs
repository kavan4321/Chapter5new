
using System.Collections.ObjectModel;

namespace Chapter5.ViewModel.CollectionData
{
    public class Car
    {
        public string Brand { get; set; }
        public string Name { get; set; }

        public int Speed { get; set; }
    }
       public class MainPageViewModel
        {

            public ObservableCollection<Car> Cars { get; set; }

            public MainPageViewModel()
            {
            Cars = new ObservableCollection<Car>
                {
                    new Car()
                    {
                        Brand = "Porsche",
                        Name = "Carrera",
                        Speed = 100
                    },

                    new Car()
                    {
                        Brand = "Jeep",
                        Name = "Cherokee",
                        Speed = 80
                    },

                    new Car()
                    {
                        Brand = "Mercedes",
                        Name = "C230",
                        Speed = 200
                    },

                    new Car()
                    {
                        Brand="Toyota",
                        Name="Corolla",
                        Speed= 150
                    },
                     new Car()
                    {
                        Brand="Hyundai",
                        Name="Creta",
                        Speed= 70
                    },
                     new Car()
                     {
                        Brand="Toyota",
                        Name="Fortuner",
                        Speed= 140
                     }

                };
            }
        }
    }