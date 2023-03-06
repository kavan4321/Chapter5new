﻿namespace Chapter5;
using View;
using View.Page1View;
using View.Page2View;
using View.Page3View;
public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new  NavigationPage(new ExpenseScreen());
	}
}