using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protractor;

namespace Acclaim_modern
{
    class PageObjects
    {

        public static string productprice()
        {
            string Modelforprice = "productPrice";

            return Modelforprice;

        }


        public static string discountonproduct(string which_object)
        {

            string Modelfordiscount = "discountPercent";
            string page_heading = "//h3[normalize-space()='Shopping Discount']";

            switch (which_object)
            {
                case "page_heading":

                    return page_heading;
                    break;

                case "discountPercent":
                    return Modelfordiscount;
                    break;


            }


            return which_object;

        }


        public static string savedAmount()
        {

            string ModelsavedAmount = "#savedAmount";
            return ModelsavedAmount;
        }
    }
}
