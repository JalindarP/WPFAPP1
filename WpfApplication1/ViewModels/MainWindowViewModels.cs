using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApplication1.Helper;
using WpfApplication1.View;

namespace WpfApplication1.ViewModels
{
    internal class MainWindowViewModels
    {
        private MainWindow _window;
        internal MainWindowViewModels(MainWindow mainWindow)
        {
            _window = mainWindow;
        }

        public ICommand StudentMenuItemClickCommand
        {
            get { return new MyCommand(StudentMenuItemExecuteAction, StudentMenuItemCanExecuteAction); }
            set { }
        }

        internal bool StudentMenuItemCanExecuteAction(object parameter)
        {
            return true;
        }

        internal void StudentMenuItemExecuteAction(object parameter)
        {
            switch (Convert.ToString(parameter))
            {
                case "StudentView":
                    _window.Content.Children.Add(new StudentControl( new StudentViewModel()));
                    break;
            }
        
       
        }

    }
}
