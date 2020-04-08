using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BillingManagement.UI.ViewModels.Commands
{
    public class CustomerCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        Action _execute;

        public CustomerCommand(Action action)
        {
            _execute = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute.Invoke();
        }
    }
}
