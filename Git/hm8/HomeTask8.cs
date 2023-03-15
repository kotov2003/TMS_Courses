using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.hm8
{
    internal class HomeTask8
    {
        public static bool RegisterNewAccount(string loginName, string password, string confirmPassword)
        {
            var IsLoginOk = ValidateLogin(loginName);
            var IsPasswordOk = ValidatePassword(password);
            var IsConfirmPassOk = ValidateConfirmPass(confirmPassword, password);

            return IsLoginOk && IsPasswordOk && IsConfirmPassOk;
        }

        private static bool ValidateLogin(string login)
        {
            if (login.Length < 20 && !login.Contains(' '))
            {
                return true;
            }
            else
            {
                throw new WrongLoginException("Login is wrong");
            }
        }

        private static bool ValidatePassword(string password)
        {
            if (password.Length < 20 && !password.Contains(' ') && password.Any(char.IsDigit))
            {
                return true;
            }
            else
            {
                throw new WrongPasswordException("Password is wrong");
            }
        }

        private static bool ValidateConfirmPass(string confirmPassword, string password)
        {
            if (confirmPassword == password)
            {
                return true;
            }
            else
            {
                throw new WrongPasswordException("ConfirmPassword is wrong");
            }
        }
    }
}
