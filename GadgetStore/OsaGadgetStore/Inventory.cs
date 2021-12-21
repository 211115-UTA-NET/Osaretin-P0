using System;

namespace OsaGadgetStore
{
    public class Inventory
    {
        private string itemName;
        private string itemId;
        private string location;
        private double cost;
        private int Quatity;

        public Inventory(string itemName, string itemId)
        {
            this.itemId = itemId;
            this.itemName = itemName;
          //  this.cost = cost;
          //  this.location = location;
        }

        public Inventory()
        {

        }

        public void AddToInventroy()
        {
            //items.Add(itemName, itemId, price);
            //items.Add(new Inventory(itemName, itemId, price));
        }

        public void DeleteFromInventroy()
        {
            //items.Add(itemName, itemId, price);
            //items.Add(new Inventory(itemName, itemId, price));
        }

        public List<MyData> GetAllInventory()
        {
            //items.Add(itemName, itemId, price);
          //  List<Inventory> items = new List<Inventory>();
           // items = new List<test>();


            Connection repository = new Connection(connectionString);

            List<MyData> allRecords = repository.GetAllRoundsOfPlayer();
         //  items = repository.GetAllRoundsOfPlayer();

            return allRecords;
        }

        public List<Inventory> AddInventory()
        {
            //items.Add(itemName, itemId, price);
            // List<Inventory> items = new List<Inventory>();
            items = new List<Inventory>();

            items.Add(new Inventory( "", ""));

          //  IConn repository = new Connection(connectionString);

            return items;
        }
    }
}

