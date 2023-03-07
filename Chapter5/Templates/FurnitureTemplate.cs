
using Chapter5.Model.Page3Model;

namespace Chapter5.Templates.FurnitureTemp;

public class FurnitureTemplate: DataTemplateSelector
{
    
    public DataTemplate ChairTemplate { get; set; }
    public DataTemplate TableTemplate { get; set; }
    public DataTemplate SofaTemplate { get; set; }
    public DataTemplate CupBoaradTemplate {  get; set; }


    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var Items = item as FurnitureModel;
        if(Items.FurnitureType == FurnitureTypes.Chairs.ToString())
        {
            return ChairTemplate;
        }
        else if(Items.FurnitureType == FurnitureTypes.Tables.ToString())
        {
            return TableTemplate;
        }
        else if(Items.FurnitureType == FurnitureTypes.Sofa.ToString())
        {
            return SofaTemplate;
        }
        else
        {
           return CupBoaradTemplate;
        }
    }
}
