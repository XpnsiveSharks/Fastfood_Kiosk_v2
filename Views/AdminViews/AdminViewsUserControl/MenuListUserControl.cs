using Fastfood_Kiosk_v2.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl
{
    public partial class MenuListUserControl : UserControl
    {
        public delegate void MenuListUserControlClickedEventHandler();
        public event MenuListUserControlClickedEventHandler MenuListUserControlAddMenuClicked;
        public event MenuListUserControlClickedEventHandler MenuListUserControlAddMenuNavigateToUpdateDeleteUserControl;

        private readonly MenuViewModel menuViewModel = new MenuViewModel();
        private UpdateDeleteUserControl updateDeleteUserControl;
        public MenuListUserControl()
        {
            InitializeComponent();
            LoadMenus();
        }
        public void LoadMenus()
        {
            MenuListDataGridView.DataSource = menuViewModel.Menus;
            CustomizeDataGridViewHeaders();
        }

        private void CustomizeDataGridViewHeaders()
        {   
            if (MenuListDataGridView.Columns.Contains("Menu_Name"))
            {
                MenuListDataGridView.Columns["Menu_Name"].HeaderText = "Menu Name";
            }
            if (MenuListDataGridView.Columns.Contains("Menu_Image_File_Path"))
            {
                MenuListDataGridView.Columns["Menu_Image_File_Path"].HeaderText = "Image Path";
            }
            if (MenuListDataGridView.Columns.Contains("Menu_Id"))
            {
                MenuListDataGridView.Columns["Menu_Id"].Visible = false;
            }
        }

        private void MenuListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = MenuListDataGridView.Rows[e.RowIndex];      
                int menuId = Convert.ToInt32(selectedRow.Cells["Menu_Id"].Value);
           
                MenuListUserControlAddMenuNavigateToUpdateDeleteUserControl?.Invoke();
                updateDeleteUserControl = new UpdateDeleteUserControl
                {
                    IsFromMenuListUserControl = true
                };
            }
        }
        public void ReloadMenus()
        {
            menuViewModel.LoadMenus(); 
            LoadMenus();
        }
        private void AddMenuButton_Click(object sender, EventArgs e)
        {
            MenuListUserControlAddMenuClicked?.Invoke();
        }
    }
}
