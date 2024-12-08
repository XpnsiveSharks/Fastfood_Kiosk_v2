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
    internal class OrderDetailsViewModel : INotifyPropertyChanged 
    {
        private readonly OrderDetailsRepository _orderDetailsRepository;
        public event PropertyChangedEventHandler PropertyChanged;
        public OrderDetailsViewModel()
        {
            _orderDetailsRepository = new OrderDetailsRepository();

        }
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public List<OrderDetailsUserControl> _orderControls;
        public List<OrderDetailsUserControl> OrderControls
        {
            get => _orderControls;
            set
            {
                if (_orderControls != value)
                {
                    _orderControls = value;
                    OnPropertyChanged(nameof(OrderControls));
                }
            }


        }

        public void LoadOrdersToUserControl()
        {
            List<OrderDetailsUserControl> orderDetailsUserControls = new List<OrderDetailsUserControl>();
            foreach(var item in _orderDetailsRepository.GetOrderDetails())
            {
                OrderDetailsUserControl orderDetailsUserControl = new OrderDetailsUserControl("")
                {
                    Order_Number = item.OrderNumber,
                    Order_Date = item.OrderDate,
                    Order_Type = item.OrderType

                };
            }
            OrderControls = orderDetailsUserControls;

        }

    }

}
