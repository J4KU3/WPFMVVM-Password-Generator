using PasswordGenMVVM.Command.BaseCommand;
using PasswordGenMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PasswordGenMVVM.Command
{
   public class ExitCommand:CommandBase
    {
        private readonly MainViewModel _mainviewmodel;

        public ExitCommand(MainViewModel mainViewModel)
        {
            _mainviewmodel = mainViewModel;
        }

        public override bool CanExecute(object parameter)
        {
            return base.CanExecute(parameter);
        }
        public override void Execute(object parameter)
        {
            Application.Current.Shutdown();   
        }

    }
}
