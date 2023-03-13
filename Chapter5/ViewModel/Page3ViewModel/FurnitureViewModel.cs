using Chapter5.Model.Page3Model;
using CommunityToolkit.Maui.Core.Extensions;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Chapter5.ViewModel.Page3ViewModel.FurnitureViewModels
{
     public class FurnitureViewModel :INotifyPropertyChanged
     {
        public ICommand ChangeCommand { get; private set; }
          
        private FurnitureTypeModel _itemSelect;
        public FurnitureTypeModel ItemSelect
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
        public  int TotalItems { get; set; }
   
        public ObservableCollection<FurnitureModel> FurnitureDetails { get; set;}
        public ObservableCollection<FurnitureTypeModel> FurnitureTypesDetails { get; set;}


        private ObservableCollection<FurnitureModel> _showDetails;
        public ObservableCollection<FurnitureModel> ShowDetails 
        {
            get { return _showDetails; }
            set
            {
                _showDetails = value;
                OnPropertyChanged();    
            } 
        }

       
        public void ItemChange()
        {
            
          /*  foreach( var item in FurnitureDetails)
            {
                if (item.FurnitureType == ItemSelect.FurnitureType)
                {
                    ShowDetails.Add(item);
                }
            }
          */
           ShowDetails=FurnitureDetails.Where(x=>x.FurnitureType==ItemSelect.FurnitureType).ToObservableCollection();         
        }
     
        public FurnitureViewModel() 
        {           
            FurnitureTypeValue();
            FurnitureData();
            ChangeCommand = new Command(ItemChange);
        }
        
        public void FurnitureTypeValue()
        {
            FurnitureTypesDetails = new ObservableCollection<FurnitureTypeModel>
            {
                new FurnitureTypeModel()
                {
                    FurnitureType=FurnitureTypes.Chairs,
                    FurnitureImage="chairtwo",
                },
                 new FurnitureTypeModel()
                {
                    FurnitureType=FurnitureTypes.Tables,
                    FurnitureImage="table",
                },

                  new FurnitureTypeModel()
                {
                    FurnitureType=FurnitureTypes.Sofa,
                    FurnitureImage="sofa",
                },

                   new FurnitureTypeModel()
                {
                    FurnitureType=FurnitureTypes.CupBoards,
                    FurnitureImage="cupboard",
                    
                }

            };
            ItemSelect = FurnitureTypesDetails.FirstOrDefault();
        }     
        public void FurnitureData()
        {

            FurnitureDetails = new ObservableCollection<FurnitureModel>
            {
               new FurnitureModel()
               {
                   FurnitureName="Ivonne Chair",
                   FurniturePrize="300",
                   FurnitureImage="chairtwo",
                   FurnitureType=FurnitureTypes.Chairs,
               },

               new FurnitureModel()
               {
                   FurnitureName="Office Chair",
                   FurniturePrize="300",
                   FurnitureDiscount=400,
                   FurnitureImage="chairtwo",
                   FurnitureType=FurnitureTypes.Chairs
               },
                new FurnitureModel()
               {
                   FurnitureName="Arm Chair",
                   FurniturePrize="100",
                   FurnitureDiscount=120,
                   FurnitureImage="chairtwo",
                   FurnitureType=FurnitureTypes.Chairs
               },
                 new FurnitureModel()
               {
                   FurnitureName="Ivonne Chair",
                   FurniturePrize="300",
                   FurnitureImage="chairtwo",
                   FurnitureType=FurnitureTypes.Chairs,
                   OutOfStock=true,
                   
               },

                 new FurnitureModel()
               {
                   FurnitureName="Office Chair",
                   FurniturePrize="300",
                   FurnitureImage="chairtwo",
                   FurnitureType=FurnitureTypes.Chairs
               },






                new FurnitureModel()
               {
                   FurnitureName="Office Table",
                   FurniturePrize="3000",
                   FurnitureDiscount=4000,
                   FurnitureImage="table",
                   FurnitureType =FurnitureTypes.Tables
                 },
                new FurnitureModel()
               {
                   FurnitureName="Wooden Table",
                   FurniturePrize="200",
                   FurnitureImage="table",
                   FurnitureType = FurnitureTypes.Tables,
                   OutOfStock=true
                 },






                new FurnitureModel()
               {
                   FurnitureName="Sofa",
                   FurniturePrize="100",
                   FurnitureImage="sofa",
                   FurnitureType =FurnitureTypes.Sofa
                },

           };
            ShowDetails = FurnitureDetails.Where(x => x.FurnitureType == ItemSelect.FurnitureType).ToObservableCollection();
            TotalItems = FurnitureDetails.Where(x => x.FurnitureType == ItemSelect.FurnitureType).Count();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string  propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
