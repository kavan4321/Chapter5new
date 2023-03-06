using Chapter5.Model.Page1Model;
using System.Collections.ObjectModel;

namespace Chapter5.ViewModel.Page1ViewModel.Easy
{

    public class EasyFoodViewModel
    {
       
        public ObservableCollection<EasyFoodModel> FoodDetail { get; set; }

        public EasyFoodViewModel()
        {
            FoodDetail = new ObservableCollection<EasyFoodModel>
            {
                new EasyFoodModel()
                {
                    ImageSource="icecream.png",
                    FoodName="Ice Cream",
                    FoodCal="123",
                    FoodStar="4.7",
                    FoodTime="25:30",
                    IsNew=true,              
                },
                 new EasyFoodModel()
                {
                    ImageSource="momos",
                    FoodName="Veg. Momos",
                    FoodCal="323",
                    FoodStar="3.5",
                    FoodTime="40:00",
                },
                  new EasyFoodModel()
                {
                    ImageSource="pavbhaji",
                    FoodName="Pav Bhaji",
                    FoodCal="453",
                    FoodStar="4.6",
                    FoodTime="60:00",
                    IsNew=true
                },
                   new EasyFoodModel()
                {
                    ImageSource="pizza",
                    FoodName="Pizza",
                    FoodCal="235",
                    FoodStar="4.1",
                    FoodTime="45:00",
                },
                    new EasyFoodModel()
                {
                    ImageSource="rice",
                    FoodName="Ice Cream",
                    FoodCal="123",
                    FoodStar="3",
                    FoodTime="15:00",
                    IsNew=true
                },
                     new EasyFoodModel()
                {
                    ImageSource="sanwitch",
                    FoodName="Sandwich",
                    FoodCal="234",
                    FoodStar="3.9",
                    FoodTime="20:00",
                },
                      new EasyFoodModel()
                {
                    ImageSource="thali",
                    FoodName="Gujarati Thali",
                    FoodCal="500",
                    FoodStar="4.8",
                    FoodTime="60:00",
                    IsNew=true
                },
                       new EasyFoodModel()
                {
                    ImageSource="vadapav",
                    FoodName="Vada Pav",
                    FoodCal="543",
                    FoodStar="4.2",
                    FoodTime="10:00",
                }
            };
        }
    }
}
