using Fastfood_Kiosk_v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood_Kiosk_v2.Repositories
{
    internal interface IUsersRepository
    {
        bool UpdateUsers(string currentPassword, string newPassword);
        List<Users> GetUser(string usersPassword);
        bool DeleteUser(string username, string password); 

    }
}
