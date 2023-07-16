using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordGenMVVM.Data;

namespace PasswordGenMVVM.Model
{
  public class PasswordModel:PasswordContainer
    {
        public PasswordModel(PasswordContainer passwordToCopy)
        {
            PasswordID = passwordToCopy.PasswordID;
            PasswordName = passwordToCopy.PasswordName;
            Password = passwordToCopy.Password;

        }
    }
}
