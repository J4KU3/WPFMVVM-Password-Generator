using PasswordGenMVVM.Command.BaseCommand;
using PasswordGenMVVM.ViewModel;
using PasswordGenMVVM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordGenMVVM.Model;

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
            return _mainviewmodel.ModelPassword.Password != null  && _mainviewmodel.ModelPassword.PasswordName!=null;
            

        }
        public override void Execute(object parameter)
        {
       
            
        }

    }
}
