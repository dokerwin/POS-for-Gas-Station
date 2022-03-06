using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MWS.Helper_Classes
{
    public class MyCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action<object> _execute;
        public MyCommand(Action<object> execute) => _execute = execute;
        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter) => _execute.Invoke(parameter);
    }
}
