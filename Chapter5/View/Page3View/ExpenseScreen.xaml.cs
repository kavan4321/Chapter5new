using Chapter5.ViewModel.Page3ViewModel.ExpenseViewModel;

namespace Chapter5.View.Page3View;

public partial class ExpenseScreen : ContentPage
{
	private readonly ExpenseViewModel _viewModel;
	public ExpenseScreen()
	{
		InitializeComponent();
		_viewModel = (ExpenseViewModel)BindingContext;
	}
}