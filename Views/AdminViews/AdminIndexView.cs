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
        private AdminUserControl adminUserControl;
        private readonly InsertMenuUserControl insertMenuUserControl = new InsertMenuUserControl();
        private InsertProductUserControl insertProductUserControl = new InsertProductUserControl();
        private readonly CashierUserControl cashierUserControl = new CashierUserControl();  
        private readonly ReportsUserControl reportsUserControl = new ReportsUserControl();
        private readonly AdminUserControl adminUserCotrol = new AdminUserControl();
        public AdminIndexView()
        {
            InitializeComponent();
            LoadInitialUserControl();
            insertMenuUserControl.InsertMenuUserControlGoToMenuListClicked += LoadInitialUserControl;
            ChangeUserControl(cashierUserControl);

        }
        private void TopMostForm()
        {
            UpdateDeleteDialogView updateDeleteDialogView = new UpdateDeleteDialogView();
            updateDeleteDialogView.TopMost = true;
        }
        private void LoadInitialUserControl()
        {
            adminUserControl = new AdminUserControl();
            AdminIndexPanel.Controls.Clear();
            AdminIndexPanel.Controls.Add(adminUserControl);

            adminUserControl.MenuListAdminUserControlClicked += OnMenuListAdminUserControlClicked;
            adminUserControl.ProductListAdminUserControlClicked += OnProductListAdminUserControlClicked;
            
        }
        private void OnMenuListAdminUserControlClicked()
        {
            insertMenuUserControl.InsertMenuUserControlClicked += LoadInitialUserControl;
            AdminIndexPanel.Controls.Clear();
            AdminIndexPanel.Controls.Add(insertMenuUserControl);
        }
        private void OnProductListAdminUserControlClicked()
        {
            //insertProductUserControl.InsertProductUserControlClicked += LoadInitialUserControl;

            AdminIndexPanel.Controls.Clear();
            AdminIndexPanel.Controls.Add(insertProductUserControl);
        }
        private void AdminButton_Click(object sender, EventArgs e)
        {
            LoadInitialUserControl();
        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            
        }

        private void AdminIndexView_Load(object sender, EventArgs e)
        {

        }

        private void SalesButton_Click(object sender, EventArgs e)
        {

        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            AdminIndexPanel.Controls.Clear();
            AdminIndexPanel.Controls.Add(reportsUserControl);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click_1(object sender, EventArgs e)
        {
            ChangeUserControl(cashierUserControl);

        }

        public void ChangeUserControl(UserControl userControl)
        {
            AdminIndexPanel.Controls.Clear();
            AdminIndexPanel.Controls.Add(userControl);
        }

        private void AdminButton_Click_1(object sender, EventArgs e)
        {
            ChangeUserControl(adminUserCotrol);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
            
            if (result == DialogResult.Yes) 
            { 
                this.Close(); 
            }
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {

        }
    }
}
