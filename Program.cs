using System;

namespace milestone._1
{
    public class Class1
    {

        class inventoryItems
        {
            private string name;
            private int productNumber;
            private double productPrice;
            private double productQuanity;

            public inventoryItems(string name, int prodcutNumber, double productQuanity, double productPrice)
            {
                this.name = name;
                this.productNumber = prodcutNumber;
                this.productPrice = productPrice;
                this.productQuanity = productQuanity;
            }

            public inventoryItems()
            {

            }

            //start of Getting Name
            public void setName(string name)
            {
                this.name = name;
            }

            public void getName()
            {
                Console.WriteLine("Product " + name);
            }
            // End of Get Name


            //----------------


            //Start of getting productNumber
            public void setNumber(int productNumber)
            {
                this.productNumber = productNumber;
            }

            public void getNumber()
            {
                Console.WriteLine("Product Number " + productNumber);
            }
            // end of getting product number 


            //----------------


            //start of getting price
            public void setPrice(int productPrice)
            {
                this.productPrice = productPrice;
            }

            public void getPrice()
            {
                Console.WriteLine("Product Price " + productPrice);
            }
            // end of product price


            //------------------


            // start of product quanity
            public void setsetQuanity(int productQuanity)
            {
                this.productQuanity = productQuanity;
            }

            public void getQuanity()
            {
                Console.WriteLine("Product quanity " + productQuanity);
            }
            //end of product quanity

            //--------------------

            //Display Items
            public void printItems()
            {
                Console.WriteLine("Products Name: " + name);
                Console.WriteLine("Product Number: " + productNumber);
                Console.WriteLine("Product Price: " + productPrice);
                Console.WriteLine("Prodcut Quanity " + productQuanity);
            }



            //item1 test
            public static void Main(string[] args)
            {
                inventoryItems testItems = new inventoryItems();

                testItems.name = "iPhone25";
                testItems.productNumber = 24680;
                testItems.productPrice = 999.99;
                testItems.productQuanity = 18;

                testItems.printItems();

            }
        }
    }
}

