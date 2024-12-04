using Fastfood_Kiosk_v2.Models;
using Fastfood_Kiosk_v2.Repositories;
using Fastfood_Kiosk_v2.Services;
using Fastfood_Kiosk_v2.Views.Customer.CustomerUserControls;
using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.Customer
{

    public partial class PaymentMethodView : Form
    {
        private readonly OrderingService orderingService = new OrderingService();
        private readonly OrdersRepository ordersRepository = new OrdersRepository();
        private readonly CustomerRepository customerRepository = new CustomerRepository();
        private string customerNumber;
        private string orderNumber;
        private string dateAndTime;
        public List<OrderListUserControl> OrderItems { get; set; }
        public string OrderType { get; set; }
        public OrderListView OrderListViewReference { get; set; }
        public PaymentMethodView(string orderType, List<OrderListUserControl> orderItems)
        {
            InitializeComponent();
            OrderType = orderType;
            OrderItems = orderItems;

        } 
        private void QRPayButton_Click(object sender, EventArgs e)
        {
            CreateOrder("QR Pay");
            string receiptContent = GenerateReceiptContent(OrderItems, "QR Pay");
            PrintReceipt(receiptContent);
            RestartApplication();
        }
        private void CashPaymentButton_Click(object sender, EventArgs e)
        {
            CreateOrder("Cash Payment");

            string receiptContent = GenerateReceiptContentForCashPayment();
            PrintReceipt(receiptContent);

            RestartApplication();
        }
        private void OnlinePayment_Click(object sender, EventArgs e)
        {
            CreateOrder("Online Payment");
            string receiptContent = GenerateReceiptContent(OrderItems, "Online Payment");
            PrintReceipt(receiptContent);
            RestartApplication();
        }
        private void RestartApplication()
        {
            this.Close();
            var customerMainFrameView = new CustomerMainFrameView();
            customerMainFrameView.Show();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (OrderListViewReference != null)
            {
                OrderListViewReference.Show(); 
                this.Close(); 
            }
        }
        private void CreateOrder(string paymentMethod)
        {
            customerNumber = orderingService.AddCustomer();
            var customerId = customerRepository.GetCustomerIdByCustomerNumber(customerNumber);
            dateAndTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if (customerId == 0)
            {
                MessageBox.Show("Invalid Customer ID. Please try again.");
                return;
            }
            var totalAmount = OrderItems.Sum(item => item.TotalPrice);
            orderNumber = orderingService.GenerateNumber("Order", orderingService.GetNumericPart(ordersRepository.GetOrderNumber()));
            var newOrder = new Orders
            {
                Order_Number = orderNumber,
                Order_Date = dateAndTime,
                Order_Type = OrderType,
                Customer_Id = customerId,
                Total_Amount = totalAmount,
                Status = "Pending",
                Payment_Method = paymentMethod
            };
            orderingService.OrderPlaced(newOrder);

            foreach (var orderItem in OrderItems)
            {
                var newOrderItems = new OrderItems
                {
                    Order_Id = ordersRepository.GetOrderIdByOrderNumber(orderNumber),
                    Product_Id = orderItem.ProductId,
                    Quantity = orderItem.Quantity,
                    Price = orderItem.TotalPrice
                };
                orderingService.AddToCart(newOrderItems);
            }
        }
        public string GenerateReceiptContentForCashPayment()
        {
            StringBuilder receiptContent = new StringBuilder();
            receiptContent.AppendLine("Receipt for Order");
            receiptContent.AppendLine("-------------------------");
            receiptContent.AppendLine($"customer number: {customerNumber}");
            receiptContent.AppendLine("-------------------------");
            receiptContent.AppendLine($"order number: {orderNumber}");
            receiptContent.AppendLine("-------------------------");
            receiptContent.AppendLine($"order number: {dateAndTime}");
            return receiptContent.ToString();
        }
        public string GenerateReceiptContent(List<OrderListUserControl> orderItems, string paymentMethod)
        {
            StringBuilder receiptContent = new StringBuilder();
            double totalAmount = 0;
            receiptContent.AppendLine(dateAndTime);
            receiptContent.AppendLine("-------------------------");
            receiptContent.AppendLine("Receipt for Order");
            receiptContent.AppendLine("-------------------------");

            foreach (var item in orderItems)
            {
                receiptContent.AppendLine($"{item.Product} x{item.Quantity} - ${item.TotalPrice}");
                totalAmount += item.TotalPrice; 
            }

            receiptContent.AppendLine("-------------------------");
            receiptContent.AppendLine($"Total: ${totalAmount}");

            receiptContent.AppendLine($"Payment Method: {paymentMethod}");
            receiptContent.AppendLine("-------------------------");

            receiptContent.AppendLine($"order number: {orderNumber}");

            receiptContent.AppendLine("-------------------------");
            receiptContent.AppendLine("Thank you for your purchase!");

            return receiptContent.ToString();
        }
        public void PrintReceipt(string receiptContent)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (sender, e) =>
            {
                // Set font and position
                Font font = new Font("Arial", 10);
                float lineHeight = font.GetHeight();
                float x = 10;
                float y = 10;

                // Split the receipt content into lines and print them
                foreach (var line in receiptContent.Split('\n'))
                {
                    e.Graphics.DrawString(line, font, Brushes.Black, new PointF(x, y));
                    y += lineHeight;
                }
            };

            printDocument.Print();
        }

    }
}
