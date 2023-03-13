
using Chapter5.Model.Page4Model;
using CommunityToolkit.Maui.Core.Extensions;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Chapter5.ViewModel.Page4ViewModel.ClothViewModel
{
    public class ClothesViewModel : INotifyPropertyChanged
    {
        public ICommand SelectionCommand { get;private set; }
        public ObservableCollection<ClothesModel> ClothesDetails { get; set; }
        public ObservableCollection<CategoryModel> CategoriesDetails { get; set; }

        private ObservableCollection<ClothesModel> _clothShow;
        public ObservableCollection<ClothesModel> ClothShow
        {
            get
            {
                return _clothShow;
            }
            set
            {
                _clothShow = value;
                OnPropertyChanged();
            }
        }

        private CategoryModel _itemSelect;
        public CategoryModel ItemSelect
        {
            get
            {
                return _itemSelect;
            }
            set
            {
                _itemSelect = value;
                OnPropertyChanged();
            }
        }
       
        
        public ClothesViewModel()
        {
            CategoriesDetail();
            ClothDetail();
            SelectionCommand = new Command(SelectShow);
        }

       

        public void CategoriesDetail()
        {
            CategoriesDetails =new ObservableCollection<CategoryModel>
            {
                new CategoryModel
                {
                    Category=Categorys.All
                },
                new CategoryModel
                {
                    Category=Categorys.Winter
                },
                new CategoryModel
                {
                    Category=Categorys.Men
                },
                new CategoryModel
                {
                    Category=Categorys.Women
                },
                new CategoryModel
                {
                    Category=Categorys.Sports
                },
                new CategoryModel
                {
                    Category=Categorys.Other
                },
            };
            ItemSelect=CategoriesDetails.FirstOrDefault();
        }
        public void ClothDetail()
        {
            ClothesDetails = new ObservableCollection<ClothesModel>
            {
                new ClothesModel()
                {
                    GenderS=Gender.Men,
                    ClothType=Categorys.Winter,
                    ClothName= "Fort Collin",
                    ClothImage="menfour",
                    ClothPrize="149.99"                 
                },
                new ClothesModel()
                {
                    GenderS=Gender.Men,
                    ClothType=Categorys.Winter,
                    ClothName= "Roadster",
                    ClothImage="menone",
                    ClothPrize="255.99"
                },
                new ClothesModel()
                {
                    GenderS=Gender.Men,
                    ClothType=Categorys.Winter,
                    ClothName= "Oxford Shirts",
                    ClothImage="mentwo",
                    ClothPrize="123.99"
                },
                new ClothesModel()
                {
                    GenderS=Gender.Men,
                    ClothType=Categorys.Winter,
                    ClothName= "Fort Collin",
                    ClothImage="mentwo",
                    ClothPrize="111.11"
                },
              
                
                new ClothesModel()
                {
                    GenderS=Gender.Men,
                    ClothType=Categorys.Men,
                    ClothName= "Levi's",
                    ClothImage="menone",
                    ClothPrize="121.23"
                },
                new ClothesModel()
                {
                    GenderS=Gender.Men,
                    ClothType=Categorys.Men,
                    ClothName= "Peter England",
                    ClothImage="mentwo",
                    ClothPrize="99.99"
                },
                new ClothesModel()
                {

                    GenderS=Gender.Men,
                    ClothType=Categorys.Men,
                    ClothName= "Ben Martin",
                    ClothImage="menone",
                    ClothPrize="124.23"
                },
                new ClothesModel()
                {

                    GenderS=Gender.Men,
                    ClothType=Categorys.Men,
                    ClothName= "Red Tape",
                    ClothImage="menfour",
                    ClothPrize="22.99"
                },



                new ClothesModel()
                {

                    GenderS=Gender.Women,
                    ClothType=Categorys.Women,
                    ClothName= "Red Tape",
                    ClothImage="womenfive",
                    ClothPrize="22.49"
                },
                 new ClothesModel()
                {

                     GenderS=Gender.Women,
                    ClothType=Categorys.Women,
                    ClothName= "Ben Martin",
                    ClothImage="women1",
                    ClothPrize="65.99"
                },
                  new ClothesModel()
                {

                    GenderS=Gender.Women,
                    ClothType=Categorys.Women,
                    ClothName= "Peter England",
                    ClothImage="womentwo",
                    ClothPrize="229.99"
                },
                   new ClothesModel()
                {

                    GenderS=Gender.Women,
                    ClothType=Categorys.Women,
                    ClothName= "Red Tape",
                    ClothImage="womenthree",
                    ClothPrize="252.99"
                },
                    new ClothesModel()
                {
                    GenderS=Gender.Women,
                    ClothType=Categorys.Women,
                    ClothName= "Red Tape",
                    ClothImage="womenfour",
                    ClothPrize="322.99"
                },
            };
            ClothShow = ClothesDetails.ToObservableCollection();
        }

        public void SelectShow()
        {
            ClothShow=ClothesDetails.Where(x=>x.ClothType==ItemSelect.Category).ToObservableCollection();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
