using PasswordGenMVVM.Command.BaseCommand;
using PasswordGenMVVM.ViewModel;
using PasswordGenMVVM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenMVVM.Command.History
{
   public class EditPasswordCommand:CommandBase
    {
        private readonly MainViewModel _mainviewmodel;

        public EditPasswordCommand(MainViewModel mainViewModel)
        {
            _mainviewmodel = mainViewModel;
        }

        public override bool CanExecute(object parameter)
        {
            if (_mainviewmodel.SelectedPassword != null)
            {
                return true;
            }
            return false;
        }

        public override void Execute(object parameter)
        {
            using (var resource = new PasswordGenMVVMEntities())
            {

                var passwordToChange = resource.PasswordContainer.FirstOrDefault(x => x.PasswordID == _mainviewmodel.SelectedPassword.PasswordID);

                if (passwordToChange != null)
                {
                    passwordToChange.PasswordName = _mainviewmodel.SelectedPassword.PasswordName;
                    passwordToChange.Password = _mainviewmodel.SelectedPassword.Password;
                    resource.SaveChanges();
                    _mainviewmodel.loadDataCommand.Execute(0);
                }


            }
        }


    }
}
