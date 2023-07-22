using PasswordGenMVVM.Command.BaseCommand;
using PasswordGenMVVM.ViewModel;
using PasswordGenMVVM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordGenMVVM.Model;
using System.Windows;

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
            
            return true;

        }
        public override void Execute(object parameter)
        {
            try
            {
                if (_mainviewmodel.ModelPassword.PasswordName != null)
                {
                    using (var resource = new PasswordGenMVVMEntities())
                    {
                        var newpassword = new PasswordContainer
                        {
                            PasswordName = _mainviewmodel.ModelPassword.PasswordName,
                            Password = _mainviewmodel.ModelPassword.Password,
                        };
                        resource.PasswordContainer.Add(newpassword);
                        resource.SaveChanges();
                        _mainviewmodel.loadDataCommand.Execute(0);
                        MessageBox.Show("add password to database");
                    }
                }
                else
                {
                    MessageBox.Show(" TexBox is null");
                }

            }
            catch (Exception)
            {
              
                throw;
            }
            
        }

    }
}
