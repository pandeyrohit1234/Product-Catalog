using System;
using System.Collections.Generic;
using System.Text;

namespace Taazaa_Assignment2
{
    public class ProductStore : Products
    {
        public List<Products> Products { get; set; }

        public List<Products> GetProducts()
        {

            var a = new List<Products>
            {
                new Products
                {
                    ProductID = 1,
                    ProductName = "Laptop",
                    Manufacturer = "Lenovo",
                    ShortCode = "qwe",
                    Description = "RAM : 8gb, CORE : I3",
                    SellingPrice = 50000
                },

               new Products
                {
                    ProductID = 2,
                    ProductName = "Keyboard",
                    Manufacturer = "Dell",
                    ShortCode = "rty",
                    Description = " Portable",
                    SellingPrice = 2000
                },



            };

            //    public static List<Products> products = new List<Products>()
            //    {
            //    new Products()
            //    {

            //            ProductID = 1,
            //            ProductName = "Laptop",
            //            Manufacturer = "Lenovo",
            //            ShortCode = "qwe",
            //            Description = "RAM : 8gb, CORE : I3",
            //            SellingPrice = 50000



            //    },
            //    new Products()
            //    {

            //            ProductID = 2,
            //            ProductName = "Keyboard",
            //            Manufacturer = "Dell",
            //            ShortCode = "rty",
            //            Description = " Portable",
            //            SellingPrice = 2000

            //    }
            //};

            a.ForEach(item => Console.WriteLine(item));
            return a;
        }

    }
}
