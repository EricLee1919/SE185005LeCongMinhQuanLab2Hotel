using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL.Repository
{
    public class LoginRepository
    {
        private FuminiHotelManagementContext _context;

        public LoginRepository()
        {
            _context = new();
        }
        public bool IsAdmin(string email, string password)
        {
            var (adminEmail, adminPassword) = _context.GetAdminCredentials();
            return email == adminEmail && password == adminPassword;
        }

        public Customer GetCustomerByEmailAndPassword(string email, string password)
        {
            return _context.Customers.FirstOrDefault(c => c.EmailAddress == email && c.Password == password);
        }

    }
}
