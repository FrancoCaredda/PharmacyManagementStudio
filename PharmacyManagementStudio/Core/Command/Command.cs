using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PharmacyManagementStudio.Core.Command
{
    public class Command : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public Action<object> ExecuteFunc { get; set; }
        public Func<object, bool> CanExecuteFunc { get; set; }

        public Command(Action<object> execute, Func<object, bool> canExecute = null)
        {
            ExecuteFunc = execute;
            CanExecuteFunc = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (CanExecuteFunc is null)
            {
                return true;
            }

            return CanExecuteFunc.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            ExecuteFunc?.Invoke(parameter);
        }
    }
}
