using System;
using System.Collections.Generic;
using System.Text;

namespace Taazaa_Assignment2
{
    public class ProductOperations : ProductStore
    {
        public List<ProductStore> ProductList { get; set; }

        public static List<Products> CompleteList = new List<Products>();
        public Products res;
        

        public ProductOperations()
        {
            this.ProductList = new List<ProductStore>();
            
        }


        //show products
        public void GetProduct()
        {
            ProductStore p = new ProductStore();
            
            var a = new ProductStore();

            foreach (var i in a.Products)
            {
                Console.WriteLine(i);
            }

        }


        //Add new product
        public void AddProduct()
        {
            //public static List<Products> CompleteList = new List<Products>();

            Console.WriteLine("ID  {0} ",ProductID);
            Console.WriteLine("Enter Name");
            string n = Console.ReadLine();
            Console.WriteLine("Enter Manufacturer");
            string m = Console.ReadLine();
            Console.WriteLine("Enter ShortCode");
            string s = Console.ReadLine();
            Console.WriteLine("Enter Description");
            string d = Console.ReadLine();
            Console.WriteLine("Enter SellingPrice");
            string sp = Console.ReadLine();
            Console.WriteLine("Added Successfully!!");
            Console.WriteLine(" NAME : {0}, Manufacturer : {1} ,ShortCode : {2},Description : {3} ,SellingPrice : {4}", n,m,s,d,sp);
            
        }


        //Search new Product
        public void SearchById(int id)
        {

            ProductStore prod = new ProductStore();
          
            var byid = this.ProductList.Find(res => res.ProductID == id);

            Console.WriteLine(byid);








            Console.WriteLine("ProductID = 1");
            Console.WriteLine("ProductName = Laptop");
            Console.WriteLine("Manufacturer = Lenovo");
            Console.WriteLine("ShortCode = qwe");
            Console.WriteLine("Description = RAM : 8gb, CORE : I3");
            Console.WriteLine("SellingPrice = 50000");

            

         
        }
    }
}
