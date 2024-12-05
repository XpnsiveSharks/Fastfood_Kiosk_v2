using Fastfood_Kiosk_v2.Models;
using Fastfood_Kiosk_v2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood_Kiosk_v2.Services
{
    internal class OrderingService
    {
        public OrderingService() 
        {

        }
        public void AddToCart(OrderItems orderItems)
        {
            var orderItemsRepository = new OrderItemsRepository();
            orderItemsRepository.AddOrderItems(orderItems);
        }
        private string GetCurrentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        public string AddCustomer()
        {
            var customerRepository = new CustomerRepository();
            var lastInsertedCustomerNumber = GenerateNumber("Customer", GetNumericPart(customerRepository.GetCustomerNumber()));
            var newCustomer = new Customer
            {
                Created_At = GetCurrentDate,
                Customer_Number = lastInsertedCustomerNumber
            };
            customerRepository.AddCustomer(newCustomer);
            return lastInsertedCustomerNumber;
        }
        public string GenerateNumber(string typeOfNumberGenerated, int lastInsertedNumber) 
        {
            lastInsertedNumber++;
            if (typeOfNumberGenerated == "Customer") 
                return $"C{lastInsertedNumber.ToString("D5")}";
            else
                return $"B{lastInsertedNumber.ToString("D5")}";
        }
        public int GetNumericPart(string input)
        {
            string numericString = string.Empty;
            foreach (var c in input)
            {
                if (char.IsDigit(c))
                    numericString += c; 
            }
            return int.TryParse(numericString, out int result) ? result : 0;
        }
        public void OrderPlaced(Orders orders)
        {
            var ordersRepository = new OrdersRepository();
            ordersRepository.AddOrders(orders);
            
        }

    }
}
