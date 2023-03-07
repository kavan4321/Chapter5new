using Chapter5.Model.Page2Model;
using CommunityToolkit.Maui.Alerts;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Chapter5.ViewModel.Page2ViewModel.ExpenseViewModel
{
    public class ExpenseViewModel:INotifyPropertyChanged
    {
        public ICommand AddCommand { get; private set; }
        public ICommand DeleteCommand { get;private set; }
       
        private ObservableCollection<ExpenseModel> _expenseModels;
        public ObservableCollection<ExpenseModel> ExpenseModelDetails 
        {
            get { return _expenseModels; }

            set
            {
                _expenseModels = value;
                OnPropertyChanged();
            } 
        }

        private string _expenceName;
        public string ExpenseName
        {
            get {  return _expenceName; }
            set {
                _expenceName = value;
                OnPropertyChanged();
            }
        }
        private string _amount;
        public string Amount
        {
            get { return _amount; }
            set
            {
                _amount = value;
                OnPropertyChanged();
            }
        }

        private double _totalAmount;
        public double TotalAmount
        {
            get { return _totalAmount; }
            set
            {
                _totalAmount = value;
                OnPropertyChanged();
            }
        }

        public void AddValue()
        {

            if (string.IsNullOrWhiteSpace(ExpenseName) && string.IsNullOrWhiteSpace(Amount))              
            {
                Toast.Make("Please Enter Expence and Amount",CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if (string.IsNullOrWhiteSpace(ExpenseName))
            {
                Toast.Make("Please Enter Expence", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else if (string.IsNullOrWhiteSpace(Amount))
            {
                Toast.Make("Please Enter Amount", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            }
            else
            {
                ExpenseModelDetails.Add(new ExpenseModel
                {
                    ExpenseName = ExpenseName,
                    Amount =double.Parse(Amount),
                });
                TotalAmount = ExpenseModelDetails.Sum(value => value.Amount);
            }
        }


        public void DeleteValue(ExpenseModel expenseModel)
        {
            ExpenseModelDetails.Remove(expenseModel);
            TotalAmount= ExpenseModelDetails.Sum(value => value.Amount);
        }
        public ExpenseViewModel()
        {
            AddCommand =new Command (AddValue);
            DeleteCommand=new Command<ExpenseModel>(DeleteValue);
            _expenseModels=new ObservableCollection<ExpenseModel>();

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
