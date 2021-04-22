using System;
using System.Collections.Generic;
using System.Text;

namespace Taazaa_Assignment2
{
    public class ProductStore : Products
    {



        public static List<Products> products = new List<Products>()
            {
            new Products()
            {
                    ProductID = Products.IncrementId(),
                    ProductName = "Laptop",
                    Manufacturer = "Lenovo",
                    ShortCode = "qwe",
                    Description = "RAM : 8gb, CORE : I3",
                    SellingPrice = 50000

            },
            new Products()
            {
                    ProductID = 2,
                    ProductName = "Keyboard",
                    Manufacturer = "Dell",
                    ShortCode = "rty",
                    Description = " Portable",
                    SellingPrice = 2000


            }
        };





    }

    
}
