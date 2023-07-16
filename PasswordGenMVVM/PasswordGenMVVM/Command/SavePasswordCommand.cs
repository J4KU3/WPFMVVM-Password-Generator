using PasswordGenMVVM.Command.BaseCommand;
using PasswordGenMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenMVVM.Command
{
  public class SavePasswordCommand:CommandBase
    {
        private readonly MainViewModel _mainviewmodel;

        public SavePasswordCommand(MainViewModel mainViewModel)
        {
            _mainviewmodel = mainViewModel;
        }

        public override bool CanExecute(object parameter)
        {
            if (_mainviewmodel.ScreenValue!=null)
            {
                return true;
            }
            return false;
        }
        public override void Execute(object parameter)
        {
           
        }

    }
}
