
using Chapter5.Model.Page1Model;

namespace Chapter5.Templates.FoodSelect
{
    
    public class FoodTemplate: DataTemplateSelector
    {
        public DataTemplate NewFood { get; set; }
        public DataTemplate OtherFood { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var items=(EasyFoodModel)item;
            if (items.IsNew == true)
            {
                return NewFood;
            }
            else
            {
                return OtherFood;
            }
        }
    }
}
