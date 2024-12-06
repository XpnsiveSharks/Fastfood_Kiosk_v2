using Fastfood_Kiosk_v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood_Kiosk_v2.Repositories
{
    internal interface IStaffRepository
    {
        void AddStaff(Staff staff);
        List<Staff> GetAllStaff();
        void UpdateStaff(Staff staffs);
        void RemoveStaff(int staffID);
        Staff GetStaffByID(int staffID);    
        
    }
}

