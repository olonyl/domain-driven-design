using DddInPractice.Logic;
using DddInPractice.UI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DddInPractice.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class SnackMachineViewModel : ViewModel
    {
        public override string Caption => "Snack Machine";
        private readonly SnackMachine _snackMachine;
        public string MoneyInTransaction=> _snackMachine.MoneyInTransaction.Amount.ToString();
        public SnackMachineViewModel(SnackMachine snackMachine)
        {
            _snackMachine = snackMachine;
        }
    }
}
