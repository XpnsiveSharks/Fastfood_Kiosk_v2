using Fastfood_Kiosk_v2.Models;
using Fastfood_Kiosk_v2.Repositories;
using Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood_Kiosk_v2.ViewModels
{
    internal class MenuViewModel : INotifyPropertyChanged
    {
        private readonly MenuRepository _menuRepository;
        public MenuViewModel()
        {
            _menuRepository = new MenuRepository();
            LoadMenus();
           // LoadMenuToUserControl();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        // Properties for adding category
        private string _menuName;
        public string MenuName
        {
            get => _menuName;
            set
            {
                if (_menuName != value)
                {
                    _menuName = value;
                    OnPropertyChanged(nameof(MenuName));
                }
            }
        }
        private List<Menus> _menus;
        public List<Menus> Menus
        {
            get => _menus;
            set
            {
                if (_menus != value)
                {
                    _menus = value;
                    OnPropertyChanged(nameof(Menus));
                }
            }
        }
        public int MenuId { get; set; }// MenuId property (for future use)
        private string _selectedMenuImagePath;
        public string SelectedMenuImagePath
        {
            get => _selectedMenuImagePath;
            set
            {
                _selectedMenuImagePath = value;
                OnPropertyChanged(nameof(SelectedMenuImagePath));
                OnPropertyChanged(nameof(SelectedMenuImage));
            }
        }

        public Image SelectedMenuImage =>
            !string.IsNullOrEmpty(_selectedMenuImagePath) ? Image.FromFile(_selectedMenuImagePath) : null;

        /// <summary>
        /// Adding Menus
        /// </summary>
        public void AddingMenu()
        {
            var newCategory = new Menus
            {
                Menu_Name = this.MenuName,
                Menu_Image_File_Path = this.SelectedMenuImagePath
            };
            _menuRepository.AddMenu(newCategory);
        }

        /// <summary>
        ///Loading categories
        /// </summary>
        public void LoadMenus()
        {
            Menus = _menuRepository.GetAllMenus() ?? new List<Menus>();
        }
        /// <summary>
        /// Updating Menus
        /// </summary>
        /// <param name="menuId"></param>
        public void UpdateMenu(int menuId)
        {
            var updatedMenu = new Menus
            {
                Menu_Id = menuId,
                Menu_Name = this._menuName,
                Menu_Image_File_Path = this.SelectedMenuImagePath
            };
            _menuRepository.UpdateMenu(updatedMenu);
        }
        public Menus GetMenuById(int menuId)
        {
            return _menuRepository.GetMenuById(menuId);
        }
        public void DeleteMenu(int menuId)
        {
            _menuRepository.DeleteMenu(menuId);
        }
        /// <summary>
        /// Property for MenuButtonsUserControl 
        /// </summary>
       /* private List<MenuButtonsUserControl> _menuControls;
        public List<MenuButtonsUserControl> MenuControls
        {
            get => _menuControls;
            set
            {
                if (_menuControls != value)
                {
                    _menuControls = value;
                    OnPropertyChanged(nameof(MenuControls));
                }
            }
        }
*/
        /// <summary>
        /// Load Menu to CustomerIndexView
        /// </summary>
        /*public void LoadMenuToUserControl()
        {
            List<MenuButtonsUserControl> menuButtonsUserControls = new List<MenuButtonsUserControl>();
            foreach (var menu in Menus)
            {
                MenuButtonsUserControl menuButtonsUserControl = new MenuButtonsUserControl
                {
                    MenuId = menu.Menu_Id
                };
                var imagePath = Path.Combine(Application.StartupPath, "Resources", menu.Menu_Image_File_Path);
                string fallbackImagePath = Path.Combine(Application.StartupPath, "Resources", "D:\\Repositories\\Resources\\no_image.jpg");
                menuButtonsUserControl.MenuImage = File.Exists(imagePath)
                    ? Image.FromFile(imagePath)
                    : Image.FromFile(fallbackImagePath);
                menuButtonsUserControls.Add(menuButtonsUserControl);

            }
            MenuControls = menuButtonsUserControls;
        }*/
        /// <summary>
        /// Loading menu to cashier user control
        /// </summary>
        /// /// <summary>
        /// Property for MenuCashierUserControl
        /// </summary>
        private List<MenuForCashierUserControl> _menuCashierControls;
        public List<MenuForCashierUserControl> MenuCashierControls
        {
            get => _menuCashierControls;
            set
            {
                if (_menuCashierControls != value)
                {
                    _menuCashierControls = value;
                    OnPropertyChanged(nameof(MenuCashierControls));
                }
            }
        }
        public void LoadMenuToCashierUserControl()
        {
            List<MenuForCashierUserControl> menuCashierUserControls = new List<MenuForCashierUserControl>();
            foreach (var menu in Menus)
            {
                MenuForCashierUserControl menuCashierUserControl = new MenuForCashierUserControl
                {
                    MenuId = menu.Menu_Id,
                    MenuName = menu.Menu_Name
                };
                menuCashierUserControls.Add(menuCashierUserControl);
            }
            MenuCashierControls = menuCashierUserControls;
        }
    }
}
