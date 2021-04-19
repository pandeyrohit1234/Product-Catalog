using System;
using System.Collections.Generic;
using System.Text;

namespace Taazaa_Assignment2
{
    public class Products
    {
        private int _id { get; set; }
        public string ProductName { get; set; }
        public string Manufacturer { get; set; }
        public string ShortCode { get; set; }

        public List<CategoriesDetails> Category;

        public string Description { get; set; }
        public int SellingPrice { get; set; }




        public int ProductID
        {

            set
            {
                this._id = ProductID + 1;
            }
            get
            {
                return this._id;
            }
        }

       public Products()
        {
            ProductID += 1;
        }
    }
}
