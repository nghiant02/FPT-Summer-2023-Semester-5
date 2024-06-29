using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class UsersServices
    {
        private readonly ElectricStoreDBContext _context;

        public UsersServices(ElectricStoreDBContext context)
        {
            _context = context;
        }

        public Users LoginAccount(string username, string password)
        {
            try
            {
                var checkLogin = _context.Users.FirstOrDefault(x => x.UserName.Equals(username) && x.Password.Equals(password));
                if (checkLogin == null)
                {
                    throw new Exception("Sorry, you are not allowed to access");
                }

                return checkLogin;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        
    }
}
