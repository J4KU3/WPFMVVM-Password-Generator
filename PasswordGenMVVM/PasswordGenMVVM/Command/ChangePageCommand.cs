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
            if (parameter.ToString() == "3")
            {
                if (_mainviewmodel.ScreenValue != null)
                {
                    _mainviewmodel.PageNumber = int.Parse(parameter as string);
                }
                else
                {
                    MessageBox.Show("first you must generate a password :D");
                }
            }
            else
            {
                _mainviewmodel.PageNumber = int.Parse(parameter as string);
            }


           
            

        }
    }
}
