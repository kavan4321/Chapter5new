
using Chapter5.Model.Page4Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Chapter5.ViewModel.Page4ViewModel.ClothViewModel
{
    public class ClothesViewModel : INotifyPropertyChanged
    {

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

        public ClothesViewModel()
        {
            CategoriesDetail();
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
        }




        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
