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
   public class DeletePasswordCommand:CommandBase
    {
        private readonly MainViewModel _mainviewmodel;

        public DeletePasswordCommand(MainViewModel mainViewModel)
        {
            _mainviewmodel = mainViewModel;
        }

        public override bool CanExecute(object parameter)
        {
            if (_mainviewmodel.SelectedPassword!=null)
            {
                return true;
            }
            return false;
        }

        public override void Execute(object parameter)
        {
            using (var resource = new PasswordGenMVVMEntities())
            {
                var passwordToDelete = resource.PasswordContainer.FirstOrDefault(x=>x.PasswordID == _mainviewmodel.SelectedPassword.PasswordID);

                if (passwordToDelete !=null)
                {
                    resource.PasswordContainer.Remove(passwordToDelete);
                    resource.SaveChanges();
                    _mainviewmodel.loadDataCommand.Execute(0);
                }


            }


        }

    }
}
