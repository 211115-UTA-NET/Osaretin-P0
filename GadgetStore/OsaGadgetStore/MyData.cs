using System;
namespace OsaGadgetStore
{
    public class MyData
    {
        private string itemName;
        private string itemId;
        private string location;
        private double cost;


        public MyData(string itemName, string itemId)
        {
            this.itemId = itemId;
            this.itemName = itemName;
            //  this.cost = cost;
            //  this.location = location;
        }
    }
}