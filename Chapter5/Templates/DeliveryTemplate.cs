
using Chapter5.Model.Page2Model;

namespace Chapter5.Templates.DeliveryTemp
{
    public class DeliveryTemplate : DataTemplateSelector
    {
        public DataTemplate VegItems {get; set; }
        public DataTemplate NonVegItems { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
           var Items=(FoodDeliveryModel)item;
            if (Items.IsVeg == true)
            {
                return VegItems;
            }
            else
            {
                return NonVegItems;
            }
        }
    }
}
