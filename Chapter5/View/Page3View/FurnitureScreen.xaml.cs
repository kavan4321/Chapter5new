using Chapter5.Model.Page3Model;
using Chapter5.Templates.FurnitureTemp;
using Chapter5.ViewModel.Page3ViewModel.FurnitureViewModels;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using Microsoft.Maui.Controls.Internals;
using System.ComponentModel;
namespace Chapter5.View.Page3View;
public partial class FurnitureScreen : ContentPage
{
	private readonly FurnitureViewModel _viewModel;
		
	public FurnitureScreen()
	{
		InitializeComponent();
		_viewModel = (FurnitureViewModel)BindingContext;
    }
	
    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

        string name = (e.CurrentSelection.FirstOrDefault() as FurnitureTypeModel)?.FurnitureType;
        Toast.Make(name, ToastDuration.Long).Show();
		_viewModel.ItemSelect = name;
    }
} 