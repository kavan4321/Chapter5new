
using Chapter5.Model.Page3Model;
using Chapter5.ViewModel.Page3ViewModel.FurnitureViewModels;
using System.Windows.Input;

namespace Chapter5.Templates.FurnitureTemp;

public class FurnitureTemplate: DataTemplateSelector
{
   
    private readonly FurnitureViewModel _viewModel;
    public DataTemplate ChairTemplate { get; set; }
    public DataTemplate TableTemplate { get; set; }
    public DataTemplate SofaTemplate { get; set; }
    public DataTemplate CupBoaradTemplate {  get; set; }

    public DataTemplate EmptyTemplate {  get; set; }   
    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        
        var Items = item as FurnitureModel;  

        if(Items == null)
        {
            return EmptyTemplate;
        }
       else  if(Items.FurnitureType == FurnitureModel.FurnitureTypes.Chairs.ToString())
        {
            return ChairTemplate;
        }
        else if(Items.FurnitureType ==FurnitureModel.FurnitureTypes.Tables.ToString())
        {
            return TableTemplate;
        }
        else if(Items.FurnitureType ==FurnitureModel.FurnitureTypes.Sofa.ToString())
        {
            return SofaTemplate;
        }
        else
        {
           return CupBoaradTemplate;
        }
    }
}
