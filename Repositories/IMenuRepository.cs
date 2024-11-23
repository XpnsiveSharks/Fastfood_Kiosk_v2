using Fastfood_Kiosk_v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood_Kiosk_v2.Repositories
{
    internal interface IMenuRepository
    {
        void AddMenu(Menus menus);
        List<Menus> GetAllMenus();
        void UpdateMenu(Menus menus);
        void DeleteMenu(int menuId);
        Menus GetMenuById(int MenuId);
    }
}
