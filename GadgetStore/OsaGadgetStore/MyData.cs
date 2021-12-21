using System;
namespace OsaGadgetStore
{
    public class MyData
    {
        private string itemName { get; set; }
        private string location;
        private double price;


        public MyData(string itemName, string itemLocation, double price)
        {
            this.location = itemLocation;
            this.itemName = itemName;
            this.price = price;
            //  this.cost = cost;
            //  this.location = location;
        }

        public string getName()
        {
            return itemName;
        }
        public double getPrice()
        {
            return price;
        }
        public string getLocation()
        {
            return location;
        }
    }
}