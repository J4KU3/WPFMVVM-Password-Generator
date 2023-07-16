using PasswordGenMVVM.Command.BaseCommand;
using PasswordGenMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenMVVM.Command.Options
{
   public class SetlengthCommand:CommandBase
    {
        private readonly MainViewModel _mainviewmodel;

        public SetlengthCommand(MainViewModel mainViewModel)
        {
            _mainviewmodel = mainViewModel;
        }

        public override bool CanExecute(object parameter)
        {
            return base.CanExecute(parameter);
        }

        public override void Execute(object parameter)
        {
            _mainviewmodel.PasswordLength = int.Parse(parameter as string);
        }
    }
}
