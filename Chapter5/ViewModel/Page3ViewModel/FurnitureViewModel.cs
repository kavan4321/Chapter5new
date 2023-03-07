
using Chapter5.Model.Page3Model;
using System.Collections.ObjectModel;

namespace Chapter5.ViewModel.Page3ViewModel.FurnitureViewModels
{
     public class FurnitureViewModel
    {
        private readonly FurnitureTypes _furnitureTypes;
        public ObservableCollection<FurnitureModel> FurnitureDetails { get; set;}

        public FurnitureViewModel() 
        {
            FurnitureDetails = new ObservableCollection<FurnitureModel>
           {

               new FurnitureModel()
               {
                   FurnitureName="Ivonne Chair",
                   FurniturePrize="300",
                   FurnitureDiscount="0",
                   FurnitureImage="cupboard",
                   FurnitureType=FurnitureTypes.Chairs.ToString(),
               },
                new FurnitureModel()
               {
                   FurnitureName="Office Table",
                   FurniturePrize="200",
                   FurnitureDiscount="0",
                   FurnitureImage="table",
                   FurnitureType=FurnitureTypes.Tables.ToString()
               },
                new FurnitureModel()
               {
                   FurnitureName="Sofa",
                   FurniturePrize="100",
                   FurnitureDiscount="10",
                   FurnitureImage="sofa",
                   FurnitureType=FurnitureTypes.Sofa.ToString()
               },
                new FurnitureModel()
               {
                   FurnitureName="Cup Board",
                   FurniturePrize="200",
                   FurnitureDiscount="0",
                   FurnitureImage="cupboard",
                   FurnitureType=FurnitureTypes.CupBoards.ToString()
               },

           };
        }
    }
}
