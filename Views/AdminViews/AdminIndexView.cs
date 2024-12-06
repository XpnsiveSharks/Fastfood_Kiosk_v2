using Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.AdminViews
{

    public partial class AdminIndexView : Form
    {
        private MenuListUserControl menuListUserControl;
        public AdminIndexView()
        {
            InitializeComponent();
            menuListUserControl = new MenuListUserControl();
            menuListUserControl.AddMenuEventHandler += OnAddMenu;
            menuListUserControl.UpdateDeleteMenuListEventHandler += OnUpdateMenu; 

        }


        private void DashboardButton_Click(object sender, EventArgs e)
        {
            
        }
        private void MenuButton_Click(object sender, EventArgs e)
        {
            LoadUserControl(menuListUserControl);
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            var productList = new ProductListUserControl();
            LoadUserControl(productList);
        }

        private void StaffButton_Click(object sender, EventArgs e)
        {

        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {

        }
        private void OnReloadMenu()
        {
            menuListUserControl.ReloadMenus();
            LoadUserControl(menuListUserControl);
        }
        private void OnAddMenu()
        {
            var insertMenuUserControl = new InsertMenuUserControl();
            insertMenuUserControl.BackToMenuListEventHandler += OnReloadMenu;
            LoadUserControl(insertMenuUserControl);
        }
        private void OnUpdateMenu(int menuId)
        {
            var insertMenuUserControl = new InsertMenuUserControl
            {
                MenuId = menuId,
                IsUpdate = true
            };
            insertMenuUserControl.InitializeControl();

            insertMenuUserControl.BackToMenuListEventHandler += OnReloadMenu;
            LoadUserControl(insertMenuUserControl);
        }

        private void LoadUserControl(UserControl userControl)
        {
            AdminIndexPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            AdminIndexPanel.Controls.Add(userControl);
        }
    }
}
