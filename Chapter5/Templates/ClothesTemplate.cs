
using Chapter5.Model.Page4Model;

namespace Chapter5.Templates.ClothTemp;

public class ClothesTemplate : DataTemplateSelector
{
    public DataTemplate NormalTemplate { get; set; }
    public DataTemplate EmptyTemplate { get; set; }
    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var Items = (ClothesModel)item;

        if(Items is null)
        {
            return EmptyTemplate;
        }
        else
        {
            return NormalTemplate;
        }
    }
}
