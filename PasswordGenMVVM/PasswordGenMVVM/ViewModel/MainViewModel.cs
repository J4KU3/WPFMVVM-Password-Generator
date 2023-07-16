using PasswordGenMVVM.Command;
using PasswordGenMVVM.Model;
using System;
using System.Collections.Generic;
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

        private int _repeat;

        public int Repeat
        {
            get
            {
                return _repeat;
            }
            set
            {
                _repeat = value;
                generatePasswordCommand.OnCanExecuteChanged();
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            generatePasswordCommand = new GeneratePasswordCommand(this);
            Repeat = 10;
            changePageCommand = new ChangePageCommand(this);
            exitCommand = new ExitCommand(this);
        }
    }
}
