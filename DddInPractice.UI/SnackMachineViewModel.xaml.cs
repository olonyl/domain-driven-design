using DddInPractice.Logic;
using DddInPractice.UI.Common;
using System.Security.Policy;
using static DddInPractice.Logic.Money;

namespace DddInPractice.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class SnackMachineViewModel : ViewModel
    {
        public override string Caption => "Snack Machine";
        private readonly SnackMachine _snackMachine;
        public string MoneyInTransaction=> _snackMachine.MoneyInTransaction.ToString();
        public Money MoneyInside => _snackMachine.MoneyInside + _snackMachine.MoneyInTransaction;

        private string _message="";

        public string Message
        {
            get { return _message; }
            set { 
                _message = value;
                Notify();
            }
        }

        public Command InsertCentCommand { get; private set; }
        public Command InsertTenCentCommand { get; private set; }
        public Command InsertQuarterCommand { get; private set; }
        public Command InsertDollarCommand { get; private set; }
        public Command InsertFiveDollarCommand { get; private set; }
        public Command InsertTwentyDollarCommand { get; private set; }
        public Command BuySnackCommand { get; private set; }   
        public Command ReturnMoneyCommand { get; private set; }
        public SnackMachineViewModel(SnackMachine snackMachine)
        {
            _snackMachine = snackMachine;
            InsertCentCommand = new Command(() => InsertMoney(Cent));
            InsertTenCentCommand = new Command(() => InsertMoney(TenCent));
            InsertQuarterCommand = new Command(() => InsertMoney(Quarter));
            InsertDollarCommand = new Command(() => InsertMoney(Dollar));
            InsertFiveDollarCommand = new Command(() => InsertMoney(FiveDollar));
            InsertTwentyDollarCommand = new Command(() => InsertMoney(TwentyDollar));
            BuySnackCommand = new Command(() => BuySnack());
            ReturnMoneyCommand = new Command(() => ReturnMoney());
        }
        private void BuySnack()
        {
            _snackMachine.BuySnack();
            NotifyClient("You have bought a snack");
        }
        private void ReturnMoney()
        {
            _snackMachine.ReturnMoney();
            NotifyClient("Money was returned");
            
        }
        private void InsertMoney(Money money)
        {
            _snackMachine.InsertMoney(money);
            NotifyClient( $"You have inserted {money}");
        }

        private void NotifyClient(string message)
        {
            Message = message;
            Notify(nameof(MoneyInTransaction));
            Notify(nameof(MoneyInside));            
        }
     
    }
}
