using Fastfood_Kiosk_v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood_Kiosk_v2.Repositories
{
    internal interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
        string GetCustomerNumber();
        int GetCustomerIdByCustomerNumber(string customerNumber);
    }
}
