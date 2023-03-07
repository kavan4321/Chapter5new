
using Chapter5.Model.Page6Model;
using System.Collections.ObjectModel;

namespace Chapter5.ViewModel.Page6ViewModel.DeliveryViewModels
{
    public class FoodDeliveryViewModel
    {
        public ObservableCollection<FoodDeliveryModel> DeliveryDetails { get; set; }

        public FoodDeliveryViewModel()         {
            DeliveryDetails = new ObservableCollection<FoodDeliveryModel>
            {
                new FoodDeliveryModel()
                {
                    FoodImage="chicken",
                    FoodName="Tandoori Chicken Pizza",
                    FoodPrize="200",
                },
                new FoodDeliveryModel()
                {
                    FoodImage="pavbhaji",
                    FoodName="Pav Bhaji",
                    FoodPrize="100",
                    IsVeg=true,
                },
                new FoodDeliveryModel()
                {
                    FoodImage="momos",
                    FoodName="Veg. Momos",
                    FoodPrize="80",
                    IsVeg=true,
                },
                new FoodDeliveryModel()
                {
                    FoodImage="tandoori",
                    FoodName="Tandoori Chicken",
                    FoodPrize="250",
                    IsVeg=false,
                },
                new FoodDeliveryModel()
                {
                    FoodImage="vegburger",
                    FoodName="Veggie Burger From Mcdonalds",
                    FoodPrize="134",
                    IsVeg=true,
                },
                new FoodDeliveryModel()
                {
                    FoodImage="nonvegburger",
                    FoodName="Non-Veg Burger From Mcdonald",
                    FoodPrize="154",
                },
                 new FoodDeliveryModel()
                {
                    FoodImage="rice",
                    FoodName="Chicken Rice",
                    FoodPrize="123",
                },
            };
                
        }
    }
}
