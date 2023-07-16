using PasswordGenMVVM.Command.BaseCommand;
using PasswordGenMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenMVVM.Command
{
   public class ChangePageCommand:CommandBase
    {
        private readonly MainViewModel _mainviewmodel;

        public ChangePageCommand(MainViewModel mainViewModel)
        {
            _mainviewmodel = mainViewModel;
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            _mainviewmodel.PageNumber = int.Parse(parameter as string);
        }
    }
}
