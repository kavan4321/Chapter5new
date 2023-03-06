using Chapter5.ViewModel.CollectionData;
using CommunityToolkit.Maui.Alerts;

namespace Chapter5;

public partial class MainPage : ContentPage
{
	private readonly MainPageViewModel _mainPageViewModel;
	
	public MainPage()
	{
		InitializeComponent();
	}

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{

        string BrandName = (e.CurrentSelection.FirstOrDefault() as Car)?.Brand;

		Toast.Make(BrandName, CommunityToolkit.Maui.Core.ToastDuration.Short).Show();

    }

}

