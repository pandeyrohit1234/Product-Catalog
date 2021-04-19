using System;

namespace Taazaa_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductOperations po = new ProductOperations();
            CategoryOperation co = new CategoryOperation();
            ProductStore ps = new ProductStore();

            Catalogagain:
            Console.WriteLine("Select : CATEGORY|| Product || Exit : ");
            string choice = Console.ReadLine();
            Console.WriteLine("");


            if (choice.ToUpper() == "PRODUCT" )

            {
                productagain:
                Console.WriteLine("Select : 1.GET all products || 2.SEARCH product by ID|| 3.ADD product || 4.Exit || 5.Back");
                string Pchoice = Console.ReadLine();
                Console.WriteLine("");

                if(Pchoice == "1")
                {
                    ps.GetProducts();
                    goto productagain;
                }
                else if (Pchoice == "2")
                {
                    Console.WriteLine("Enter id : ");
                    int id = Int32.Parse(Console.ReadLine());
                    po.SearchById(id);
                    goto productagain;
                }
                else if (Pchoice == "3")
                {
                    po.AddProduct();
                    goto productagain;
                }
                else if (Pchoice == "4")
                {
                    Console.WriteLine("EXIT From Product");
                    goto Catalogagain;
                }
                else if(Pchoice == "5")
                {
                    Console.WriteLine("Please try again");
                    goto productagain;
                }
         
            }



            if (choice.ToUpper() == "CATEGORY")

            {
                categoryagain:
                Console.WriteLine("Select : 1.GET all category || 2.SEARCH category by ID|| 3.ADD Category || 4.Delete category || 5.Exit || 6.Back ");
                string Pchoice = Console.ReadLine();
                Console.WriteLine("");

                if (Pchoice == "1")
                {
                    CategoryOperation.ListOfAllCategories();
                    goto categoryagain;

                }
                else if (Pchoice == "2")
                {
                    CategoryOperation.SearchCategory();
                    goto categoryagain;
                }
                else if (Pchoice == "3")
                {
                    Console.WriteLine("Enter name");
                    var cn = Console.ReadLine();
                    Console.WriteLine("Enter short code");
                    var sc = Console.ReadLine();
                    Console.WriteLine("Enter description");
                    var d = Console.ReadLine();
                    CategoryOperation.AddCategory(cn,sc,d);
                }
                else if (Pchoice == "4")
                {
                    CategoryOperation.DeleteCategory();
                    Console.WriteLine("Category Deleted");
                    goto categoryagain;
                }
                else if (Pchoice == "5")
                {
                    Console.WriteLine("EXIT from Category");
                    goto Catalogagain;
                }
                else if (Pchoice == "6")
                {
                    Console.WriteLine("Please try again");
                    goto categoryagain;
                }
            }


        }
    }
}
