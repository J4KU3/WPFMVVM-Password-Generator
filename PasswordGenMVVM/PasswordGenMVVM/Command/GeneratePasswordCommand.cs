using PasswordGenMVVM.Command.BaseCommand;
using PasswordGenMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenMVVM.Command
{
    public class GeneratePasswordCommand:CommandBase
    {
        private readonly MainViewModel _mainviewmodel;

        public GeneratePasswordCommand(MainViewModel mainViewModel)
        {
            _mainviewmodel = mainViewModel;
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            try
            {
                _mainviewmodel.ScreenValue = null;
                Random random = new Random();
                char rnd;
                int r = 0;
                while (r < _mainviewmodel.PasswordLength)
                {
                    rnd = Convert.ToChar(random.Next(33, 127));
                    _mainviewmodel.ScreenValue += rnd;
                    r++;
                }
                _mainviewmodel.ModelPassword.Password = _mainviewmodel.ScreenValue;
            }
            catch (Exception)
            {

                throw;
            }
            




        }

    }
}
