using System;
using System.Collections.Generic;
using System.Text;

namespace Taazaa_Assignment2
{


    public class Category
    {
        private static int ID = 1;
        public int Category_ID { get; set; }
        public static int IncreamentID()
        {
            return ID++;
        }
        public string Category_Name { get; set; }
        public string CategoryShortCode { get; set; }
        public string CategoryDescription { get; set; }


    }




    
}
