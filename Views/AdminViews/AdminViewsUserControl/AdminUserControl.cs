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
    public partial class AdminUserControl : UserControl
    {
        public delegate void AdminUserControlClickedEventHandler();
        public event AdminUserControlClickedEventHandler MenuListAdminUserControlClicked;
        public event AdminUserControlClickedEventHandler ProductListAdminUserControlClicked;

        private readonly MenuListUserControl menuListUserControl = new MenuListUserControl();
        private InsertMenuUserControl insertMenuUserControl = new InsertMenuUserControl();
        private readonly ProductListUserControl productListUserControl = new ProductListUserControl();
        private readonly InsertProductUserControl insertProductUserControl = new InsertProductUserControl();
       
        public AdminUserControl()
        {
            InitializeComponent();
            DisplayListMenuUserControl();
        }
        private void MenuListButton_Click(object sender, EventArgs e)
        {
            ChangeUserControlInAdminUserControl(menuListUserControl);
        }
        private void ProductListButton_Click(object sender, EventArgs e)
        {
            ChangeUserControlInAdminUserControl(productListUserControl);
        }
        public void DisplayListMenuUserControl()
        {  
            ChangeUserControlInAdminUserControl(menuListUserControl);

            menuListUserControl.MenuListUserControlAddMenuClicked += OnMenuListUserControlAddMenuClicked;

            insertMenuUserControl.InsertMenuUserControlClicked += DisplayListMenuUserControl;
            menuListUserControl.MenuListUserControlAddMenuClicked += OnMenuListUserControlAddMenuClicked;

            productListUserControl.ProductListUserControlAddProductClicked += OnProductListUserControlAddProductClicked;
            insertProductUserControl.InsertProductUserControlCancelClicked += OnInsertProductUserControlCancelClicked;


        }
        private void OnMenuListUserControlAddMenuClicked()
        {
            insertMenuUserControl.InsertMenuUserControlGoToMenuListClicked += () => 
            { 
                ChangeUserControlInAdminUserControl(menuListUserControl);
                menuListUserControl.ReloadMenus(); 
            };
            ChangeUserControlInAdminUserControl(insertMenuUserControl);
        }
        private void OnProductListUserControlAddProductClicked()
        {
            ChangeUserControlInAdminUserControl(insertProductUserControl);
        }
        private void OnInsertProductUserControlCancelClicked()
        {
            ChangeUserControlInAdminUserControl(productListUserControl);
        }
        public void ChangeUserControlInAdminUserControl(UserControl userControl)
        {
            AdminFlowLayoutPanel.Controls.Clear();
            AdminFlowLayoutPanel.Controls.Add(userControl);
        }
        private void OnUpdateDialogViewClickedForMenuUpdate()
        {
            ChangeUserControlInAdminUserControl(insertMenuUserControl);
        }
    }
}
