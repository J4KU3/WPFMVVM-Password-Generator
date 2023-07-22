using PasswordGenMVVM.Command.BaseCommand;
using PasswordGenMVVM.Data;
using PasswordGenMVVM.ViewModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using PasswordGenMVVM.Model;
using System.Collections.ObjectModel;

namespace PasswordGenMVVM.Command.History
{
   public class SearchPasswordCommand:CommandBase
    {
        private readonly MainViewModel _mainviewModel;

        public SearchPasswordCommand(MainViewModel mainViewModel)
        {
            _mainviewModel = mainViewModel;
        }

        public override bool CanExecute(object parameter)
        {
            if (_mainviewModel.SearchPassword!=null)
            {
                return true;
            }
            return false;
        }

        public override void Execute(object parameter)
        {
            try
            {

                if (_mainviewModel.SearchPassword.PasswordName!=null)
                {
                   

                    using (var resource = new PasswordGenMVVMEntities())
                    {
                        List<PasswordContainer> passwordList = resource.PasswordContainer.ToList();

                      
                        List<PasswordModel> convertedList = passwordList.Select(e => new PasswordModel(e)).ToList();
                        List<PasswordModel> searchedList = convertedList.Where(x => x.PasswordName == _mainviewModel.SearchPassword.PasswordName).ToList();
                        _mainviewModel.ListOfPassword = new ObservableCollection<PasswordModel>(searchedList);


                    }

                }
                if (_mainviewModel.SearchPassword.PasswordName.ToString() == "")
                {
                  //  _mainviewModel.SearchPassword = null;
                    _mainviewModel.loadDataCommand.Execute(0);
                }
               

                  


                    







            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
