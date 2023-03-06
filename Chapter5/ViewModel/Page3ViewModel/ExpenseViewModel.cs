
using Chapter5.Model.Page3Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Chapter5.ViewModel.Page3ViewModel.ExpenseViewModel
{
    public class ExpenseViewModel:INotifyPropertyChanged
    {
        public ObservableCollection<ExpenseModel> Expense { get; set; }

        public ICommand AddCommand { get;private set; }

        private string _expenceName;
        public string ExpenseName
        {
            get {  return _expenceName; }
            set {
                _expenceName = value;
                OnPropertyChanged();
            }
        }
        private double _amount;
        public double Amount
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

            Expense = new ObservableCollection<ExpenseModel>
            {
                new ExpenseModel()
                {
                    ExpenseName = ExpenseName,
                    Amount=Amount.ToString(),
                }
            };
        }

        public ExpenseViewModel()
        {
            AddCommand =new Command (AddValue);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
