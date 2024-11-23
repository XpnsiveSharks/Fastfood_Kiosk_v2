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
using static Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl.InsertProductUserControl;

namespace Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl
{
    public partial class InsertProductUserControl : UserControl
    {
        /// <summary>
        /// Delegate for handling Insert product user control click events.
        /// </summary>
        public delegate void InsertProductUserControlClickedEventHandler();
        /// <summary>
        /// Event triggered when the Cancel Button is clicked.
        /// </summary>
        public event InsertProductUserControlClickedEventHandler InsertProductUserControlCancelClicked;

        private readonly ProductViewModel productViewModel = new ProductViewModel();
        public InsertProductUserControl()
        {
            InitializeComponent();
            ProductPreviewPictureBox.DataBindings.Add("Image", productViewModel, nameof(productViewModel.SelectedProductImage), true, DataSourceUpdateMode.OnPropertyChanged);
            ProductNameTextBox.DataBindings.Add("Text", productViewModel, nameof(productViewModel.ProductName), true, DataSourceUpdateMode.OnPropertyChanged);
            ProductPriceTextBox.DataBindings.Add("Text", productViewModel, nameof(productViewModel.ProductPrice), true, DataSourceUpdateMode.OnPropertyChanged);
            ProductDescriptionTextBox.DataBindings.Add("Text", productViewModel, nameof(productViewModel.Description), true, DataSourceUpdateMode.OnPropertyChanged);
        }
        /// <summary>
        /// Handles the click event for cancel button and triggers the corresponding event.
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">the <see cref="EventArgs"/> instance containing the event data </param> 
        private void CancelButton_Click(object sender, EventArgs e)
        {
            InsertProductUserControlCancelClicked?.Invoke();
        }

        private void ProductImageUploadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    productViewModel.ProductImageFilePath = openFileDialog.FileName;
                    MessageBox.Show("File Selected!");
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
