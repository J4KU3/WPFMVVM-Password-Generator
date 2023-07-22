using PasswordGenMVVM.Command.BaseCommand;
using PasswordGenMVVM.ViewModel;
using PasswordGenMVVM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordGenMVVM.Model;
using System.Collections.ObjectModel;

namespace PasswordGenMVVM.Command.History
{
   public class LoadDataCommand:CommandBase
    {
        private readonly MainViewModel _mainviewmodel;

        public LoadDataCommand(MainViewModel mainViewModel)
        {
            _mainviewmodel = mainViewModel;
        }

        public override bool CanExecute(object parameter)
        {
            return base.CanExecute(parameter);
        }

        public override void Execute(object parameter)
        {
            using (var context = new PasswordGenMVVMEntities())
            {


                List<PasswordContainer> passwordList = context.PasswordContainer.ToList();

              
                List<PasswordModel> convertedList = passwordList.Select(e => new PasswordModel(e)).ToList();

                _mainviewmodel.ListOfPassword = new ObservableCollection<PasswordModel>(convertedList);

            }
        }
    }
}
