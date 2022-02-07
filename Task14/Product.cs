using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    public enum Categories
    {
        Food,
        Appliances
    }
    public class Product
    {
        public string ProductName { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public Categories Category { get; set; }
       
    }
}
