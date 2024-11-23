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
    public partial class InsertMenuUserControl : UserControl
    {
        /// <summary>
        /// Delegate for handling Insert Menu User Control click events.
        /// </summary>
        public delegate void InsertMenuUserControlClickedEventHandler();
        /// <summary>
        /// Event triggered when the Cancel Menu Button is clicked.
        /// </summary>
        public event InsertMenuUserControlClickedEventHandler InsertMenuUserControlClicked;
        public event InsertMenuUserControlClickedEventHandler InsertMenuUserControlGoToMenuListClicked;

        private readonly MenuViewModel menuViewModel = new MenuViewModel();


        private int menuId;
        private bool IsUpdate;
        public InsertMenuUserControl(int menuId = 0)
        {
            InitializeComponent();

            this.menuId = menuId;
            IsUpdate = menuId != 0;
            if (IsUpdate)
                DisplaySelectedCategoriesForMenuUpdate();

            MenuPreviewPictureBox.DataBindings.Add("Image", menuViewModel, nameof(menuViewModel.SelectedMenuImage), true, DataSourceUpdateMode.OnPropertyChanged);
            MenuNameTextBox.DataBindings.Add("Text", menuViewModel, nameof(menuViewModel.MenuName), true, DataSourceUpdateMode.OnPropertyChanged);
        }
        /// <summary>
        /// Handles the click event for Cancel Menu Button and triggers the corresponding event.
        /// </summary>
        /// <param name="sender">source of the event</param>
        /// <param name="e">the <see cref="EventArgs"/> instance containing the event data</param>
        private void CancelMenuButton_Click(object sender, EventArgs e)
        {
            InsertMenuUserControlClicked?.Invoke();
        }

        private void UploadImageMenuButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    menuViewModel.SelectedMenuImagePath = openFileDialog.FileName;
                    MessageBox.Show("File Selected!");
                }
            }
        }
        private void SaveMenuButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(menuViewModel.MenuName))
            {
                MessageBox.Show("Please enter category name.");
                return;
            }
            if (string.IsNullOrEmpty(menuViewModel.SelectedMenuImagePath))
            {
                MessageBox.Show("Please upload an Image.");
                return;
            }
            if (IsUpdate)
            {
                menuViewModel.UpdateMenu(menuId);
                MessageBox.Show("Category updated successfully");
            }
            else
            {
                menuViewModel.AddingMenu();
                MessageBox.Show("Category saved successfully");
            }

            InsertMenuUserControlGoToMenuListClicked?.Invoke();
        }
        private void DisplaySelectedCategoriesForMenuUpdate()
        {
            var category = menuViewModel.GetMenuById(menuId);
            menuViewModel.MenuName = category.Menu_Name;
            menuViewModel.SelectedMenuImagePath = category.Menu_Image_File_Path;
        }
    }
}
