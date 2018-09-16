using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApplication1.Helper
{
    public class MyCommand : ICommand
    {
        private Action<object> _execute;
        private Predicate<object> _canExecute;

        internal MyCommand(Action<object> execute, Predicate<object> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
             _execute(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}
