using System;
using System.Collections.Generic;
using System.Text;

namespace Taazaa_Assignment2
{
    public  class UserInput
    {
        public static void input()
        {

            ProductOperations productobject = new ProductOperations();
            CategoryOperation Categoryobject = new CategoryOperation();



            while (true)
            {

                Console.WriteLine("Select");
                Console.WriteLine("Type 1 for PRODUCT  Operation");
                Console.WriteLine("Type 2  for CATEGORY Opertion"); 
                Console.WriteLine("Type 3  for Exit");
                
                

                int choice = Int32.Parse(Console.ReadLine());
                Console.WriteLine("");


                if (choice == 1)

                {

                    Console.WriteLine("Select"); 
                    Console.WriteLine("1.GET all products"); 
                    Console.WriteLine("2.SEARCH product by ID");
                    Console.WriteLine("3.ADD product");
                    Console.WriteLine("4.Delete");
                    Console.WriteLine("5.Back");
                    string Pchoice = Console.ReadLine();
                    Console.WriteLine("");

                    if (Pchoice == "1")
                    {
                        productobject.GetProduct();

                    }
                    else if (Pchoice == "2")
                    {
                        Console.WriteLine("Enter id : ");
                        int id = Int32.Parse(Console.ReadLine());
                        productobject.SearchById(id);

                    }
                    else if (Pchoice == "3")
                    {
                        Console.WriteLine("Enter name");
                        var cn = Console.ReadLine();
                        Console.WriteLine("Enter short code");

                        var sc = Console.ReadLine();

                        if (sc.Length <= 4)
                        {
                            Console.WriteLine("Enter description");
                            var d = Console.ReadLine();

                            Console.WriteLine("Enter selling price");
                            var s = Int32.Parse(Console.ReadLine());
                            if (s > 0)
                            {

                                ProductOperations.AddProduct(cn, sc, d, s);


                            }
                            else {
                                Console.WriteLine("Price should be larger than 0");

                            }

                        }
                        else {
                            Console.WriteLine("length is larger than 4");
                        }
                       

                    }
                    else if (Pchoice == "4")
                    {
                        Console.WriteLine("Delete From Product");
                        ProductOperations.DeleteProduct();

                    }
                    else if (Pchoice == "5")
                    {
                        Console.WriteLine("Please try again");

                    }

                }



                if (choice == 2)

                {

                    Console.WriteLine("Select");
                    Console.WriteLine("1.GET all category");
                    Console.WriteLine("2.SEARCH category by ID");
                    Console.WriteLine("3.ADD category");
                    Console.WriteLine("4.Delete");
                    Console.WriteLine("5.Back");
                    string Pchoice = Console.ReadLine();
                    Console.WriteLine("");

                    if (Pchoice == "1")
                    {
                        CategoryOperation.ListOfAllCategories();


                    }
                    else if (Pchoice == "2")
                    {
                        CategoryOperation.SearchCategory();

                    }
                    else if (Pchoice == "3")
                    {
                        Console.WriteLine("Enter name");
                        var cn = Console.ReadLine();
                        Console.WriteLine("Enter short code");
                        var sc = Console.ReadLine();
                        if (sc.Length <= 4)
                        {

                            Console.WriteLine("Enter description");
                            var d = Console.ReadLine();
                            
                                CategoryOperation.AddCategory(cn, sc, d);
                            

                        }
                        else 
                        {
                            Console.WriteLine("lenth of short code should not be larger than 4");
                        }
                    }
                    else if (Pchoice == "4")
                    {
                        CategoryOperation.DeleteCategory();
                        Console.WriteLine("Category Deleted");

                    }
                    else if (Pchoice == "5")
                    {
                        Console.WriteLine("EXIT from Category");
                       
                    }
                    else if (Pchoice == "6")
                    {
                        Console.WriteLine("Please try again");

                    }
                }
                if (choice == 3)
                {
                    Console.WriteLine("Thankyou for visiting us");
                    break;
                }


            }

        }
    }
}
