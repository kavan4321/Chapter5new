
using Chapter5.Model.Page3Model;
namespace Chapter5.Templates.FurnitureTemp;

public class FurnitureTemplate: DataTemplateSelector
{
    
    public DataTemplate NormalTemplate { get; set; }
    public DataTemplate DiscountTemplate { get; set; }
    public DataTemplate EmptyTemplate {  get; set; } 
    

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {

        var Items = (FurnitureModel)item;

        if(Items.FurnitureDiscount > 0)
        {
            return DiscountTemplate;
        }
        else if(Items.FurnitureDiscount == 0)
        {
            return NormalTemplate;
        }
        else
        {
            return EmptyTemplate;
        }
        
    }
}
