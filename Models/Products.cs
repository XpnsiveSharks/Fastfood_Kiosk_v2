using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood_Kiosk_v2.Models
{
    internal class Products
    {
        public int Product_Id { get; set; }
        public int Menu_Id { get; set; }
        public string Product_Name { get; set; }
        public double Product_Price { get; set; }
        public string Description { get; set; }
        public string Product_Image_File_Path { get; set; }
        public string Menu_Name { get; set; }
    }
}
