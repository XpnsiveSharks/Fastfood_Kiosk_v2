﻿using System;
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
    public partial class MenuForCashierUserControl : UserControl
    {
        public delegate void MenuForCashierUserControlEventHandler(int menuId);
        public event MenuForCashierUserControlEventHandler MenuForCashierUserControlClicked;
        public MenuForCashierUserControl()
        {
            InitializeComponent();
        }
        public int MenuId { get; set; }
        public string MenuName 
        { 
            get => MenuButton.Text; 
            set => MenuButton.Text = value; 
        }
        private void MenuButton_Click(object sender, EventArgs e)
        {
            MenuForCashierUserControlClicked?.Invoke(MenuId);
        }
    }
} 
