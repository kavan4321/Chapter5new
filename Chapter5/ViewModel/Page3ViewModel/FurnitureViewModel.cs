﻿
using Chapter5.Model.Page3Model;
using Chapter5.Templates.FurnitureTemp;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Chapter5.ViewModel.Page3ViewModel.FurnitureViewModels
{
     public class FurnitureViewModel :INotifyPropertyChanged
     {
        private readonly FurnitureTemplate _template;
        public ICommand ChangeCommand { get;private set; }
        
        public void Values()
        {
            if (ItemSelect == null)
            {
              ItemSelect="Chairs";
            }                   
        }
        private string _itemSelect="Chairs";
        public string ItemSelect
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
        public ObservableCollection<FurnitureModel> FurnitureDetails { get; set;}
        public ObservableCollection<FurnitureTypeModel> FurnitureTypesDetails { get; set;}

        public FurnitureViewModel() 
        {

            ChangeCommand = new Command(Values);
            FurnitureTypeValue();
            DetailData();
             
        }

        public void FurnitureTypeValue()
        {
            FurnitureTypesDetails = new ObservableCollection<FurnitureTypeModel>
            {
                new FurnitureTypeModel()
                {
                    FurnitureType=FurnitureModel.FurnitureTypes.Chairs.ToString(),
                    FurnitureImage="chairtwo"
                },
                 new FurnitureTypeModel()
                {
                    FurnitureType=FurnitureModel.FurnitureTypes.Tables.ToString(),
                    FurnitureImage="table"
                },

                  new FurnitureTypeModel()
                {
                    FurnitureType=FurnitureModel.FurnitureTypes.Sofa.ToString(),
                    FurnitureImage="sofa"
                },

                   new FurnitureTypeModel()
                {
                    FurnitureType=FurnitureModel.FurnitureTypes.CupBoards.ToString(),
                    FurnitureImage="cupboard"
                }

            };

        }
        public void DetailData()
        {
            FurnitureDetails = new ObservableCollection<FurnitureModel>
            {
               new FurnitureModel()
               {
                   FurnitureName="Ivonne Chair",
                   FurniturePrize="300",
                   FurnitureDiscount="0",
                   FurnitureImage="chairtwo",
                   FurnitureType=FurnitureModel.FurnitureTypes.Chairs.ToString()
               },

               new FurnitureModel()
               {
                   FurnitureName="Office Chair",
                   FurniturePrize="300",
                   FurnitureDiscount="400",
                   FurnitureImage="chairtwo",
                   FurnitureType=FurnitureModel.FurnitureTypes.Chairs.ToString()
               },
                new FurnitureModel()
               {
                   FurnitureName="Arm Chair",
                   FurniturePrize="100",
                   FurnitureDiscount="120",
                   FurnitureImage="chairtwo",
                   FurnitureType=FurnitureModel.FurnitureTypes.Chairs.ToString()
               },
                 new FurnitureModel()
               {
                   FurnitureName="Ivonne Chair",
                   FurniturePrize="300",
                   FurnitureDiscount="0",
                   FurnitureImage="chairtwo",
                   FurnitureType=FurnitureModel.FurnitureTypes.Chairs.ToString()
               },

                 new FurnitureModel()
               {
                   FurnitureName="Office Chair",
                   FurniturePrize="300",
                   FurnitureDiscount="0",
                   FurnitureImage="chairtwo",
                   FurnitureType=FurnitureModel.FurnitureTypes.Chairs.ToString()
               },











                new FurnitureModel()
               {
                   FurnitureName="Office Table",
                   FurniturePrize="3000",
                   FurnitureDiscount="4000",
                   FurnitureImage="table",
                   FurnitureType = FurnitureModel.FurnitureTypes.Tables.ToString()
                 },
                new FurnitureModel()
               {
                   FurnitureName="Wooden Table",
                   FurniturePrize="200",
                   FurnitureDiscount="0",
                   FurnitureImage="table",
                   FurnitureType = FurnitureModel.FurnitureTypes.Tables.ToString()
                 },






                new FurnitureModel()
               {
                   FurnitureName="Sofa",
                   FurniturePrize="100",
                   FurnitureDiscount="10",
                   FurnitureImage="sofa",
                   FurnitureType = FurnitureModel.FurnitureTypes.Sofa.ToString()
                },





                new FurnitureModel()
               {
                   FurnitureName="Cup Board",
                   FurniturePrize="200",
                   FurnitureDiscount="0",
                   FurnitureImage="cupboard",
                   FurnitureType = FurnitureModel.FurnitureTypes.CupBoards.ToString()
               },
           };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string  propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
