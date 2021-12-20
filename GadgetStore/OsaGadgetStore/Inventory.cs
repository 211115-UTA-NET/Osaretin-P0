using System;

namespace OsaGadgetStore
{
    public class Inventory
    {
        private string itemName;
        private string itemId;
        private string location;
        private double cost;


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

       

        public void DeleteFromInventroy()
        {
            //items.Add(itemName, itemId, price);
            //items.Add(new Inventory(itemName, itemId, price));
        }

        public List<Inventory> GetInv()
        {
            //items.Add(itemName, itemId, price);
            List<Inventory> items = new List<Inventory>();
           // items = new List<test>();


            Connection repository = new Connection(connectionString);

            IEnumerable<MyData> allRecords = repository.GetAllRoundsOfPlayer();

            return items;
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

