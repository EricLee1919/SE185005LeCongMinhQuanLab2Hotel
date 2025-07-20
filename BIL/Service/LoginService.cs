using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL.Service
{
    public class LoginService
    {
        private LoginRepository _loginRepository;
        public LoginService()
        {
            _loginRepository = new ();
        }
        public string Login(string email, string password)
        {
            if (_loginRepository.IsAdmin(email, password))
            {
                return "Admin";
            }

            var customer = _loginRepository.GetCustomerByEmailAndPassword(email, password);
            if (customer != null)
            {
                return "Customer";
            }

            return null; // Đăng nhập thất bại
        }

    }
}
