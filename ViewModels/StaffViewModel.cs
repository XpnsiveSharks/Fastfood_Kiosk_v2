using Fastfood_Kiosk_v2.Models;
using Fastfood_Kiosk_v2.Repositories;
using Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood_Kiosk_v2.ViewModels
{
    internal class StaffViewModel : INotifyPropertyChanged
    {
        private readonly StaffRepository _staffRepository;

        public StaffViewModel()
        {
            _staffRepository = new StaffRepository();
            LoadStaff();
            // LoadMenuToUserControl();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private string _staffName;
        public string StaffName
        {
            get => _staffName;
            set
            {
                if (_staffName != value)
                {
                    _staffName = value;
                    OnPropertyChanged(nameof(StaffName));
                }
            }
        }

        public string StaffContact
        {
            get => _staffName;
            set
            {
                if (_staffName != value)
                {
                    _staffName = value;
                    OnPropertyChanged(nameof(StaffContact));
                }
            }
        }

        private List<Staff> _staff;
        public List<Staff> Staff
        {
            get => _staff;
            set
            {
                if (_staff != value)
                {
                    _staff = value;
                    OnPropertyChanged(nameof(Staff));
                }
            }
        }

        public void AddingStaff()
        {
            var newStaff = new Staff
            {
                Staff_Name = this.StaffName,
                Staff_Contact = this.StaffContact
            };
            _staffRepository.AddStaff(newStaff);
        }
        public void LoadStaff()
        {
            Staff = _staffRepository.GetAllStaff() ?? new List<Staff>();
        }

        public void UpdateStaff(int staffId)
        {
            var updatedStaff = new Staff
            {
                Staff_Id = staffId,
                Staff_Name = this._staffName,
            };
            _staffRepository.UpdateStaff(updatedStaff);
        }
        public Staff GetStaffByID(int staffID)
        {
            return _staffRepository.GetStaffByID(staffID);
        }
        public void RemoveStaff(int staffId)
        {
            _staffRepository.RemoveStaff(staffId);
        }
      
    }
}
