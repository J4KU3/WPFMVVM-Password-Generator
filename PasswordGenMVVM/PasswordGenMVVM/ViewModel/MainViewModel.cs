using PasswordGenMVVM.Command;
using PasswordGenMVVM.Command.Options;
using PasswordGenMVVM.Command.History;
using PasswordGenMVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PasswordGenMVVM.ViewModel
{
   public class MainViewModel:BaseViewModel
    {
       public GeneratePasswordCommand generatePasswordCommand { get; }
       public ChangePageCommand changePageCommand { get; }
       public ExitCommand exitCommand { get; }
       public SetlengthCommand setlengthCommand { get; }
       public LoadDataCommand loadDataCommand { get; }


        private ObservableCollection<PasswordModel> _listofPassword = new ObservableCollection<PasswordModel>();

        public ObservableCollection<PasswordModel> ListOfPassword
        {
            get
            {
                return _listofPassword;
            }
            set
            {
                _listofPassword = value;
                loadDataCommand.OnCanExecuteChanged();
                OnPropertyChanged();
            }
        }


        private int _pageNumber;

        public int PageNumber
        {
            get
            {
                return _pageNumber;
            }
            set
            {
                _pageNumber = value;
                changePageCommand.OnCanExecuteChanged();
                OnPropertyChanged();
            }
        }


        private PasswordModel _passwordModel;

        public PasswordModel ModelPassword
        {
            get
            {
                return _passwordModel;
            }
            set
            {
                _passwordModel = value;
              
                OnPropertyChanged();
            }
        }

        private string _screenValue;

        public string ScreenValue
        {
            get
            {
                return _screenValue;
            }
            set
            {
                _screenValue = value;
                generatePasswordCommand.OnCanExecuteChanged();
                OnPropertyChanged();
            }
        }

        private int _passwordLength;

        public int PasswordLength
        {
            get
            {
                return _passwordLength;
            }
            set
            {
                _passwordLength = value;
                generatePasswordCommand.OnCanExecuteChanged();
              //  setlengthCommand.OnCanExecuteChanged();
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            generatePasswordCommand = new GeneratePasswordCommand(this);
            changePageCommand = new ChangePageCommand(this);
            exitCommand = new ExitCommand(this);
            setlengthCommand = new SetlengthCommand(this);
            setlengthCommand.Execute("10");
            loadDataCommand = new LoadDataCommand(this);
            loadDataCommand.Execute(0);
        }
    }
}
