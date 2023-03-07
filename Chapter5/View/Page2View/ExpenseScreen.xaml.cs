using Chapter5.ViewModel.Page2ViewModel.ExpenseViewModel;

namespace Chapter5.View.Page2View;

public partial class ExpenseScreen : ContentPage
{
	private readonly ExpenseViewModel _viewModel;
	public ExpenseScreen()
	{
		InitializeComponent();
		_viewModel = (ExpenseViewModel)BindingContext;
	}
}