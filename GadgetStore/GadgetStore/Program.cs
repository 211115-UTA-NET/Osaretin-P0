﻿using OsaGadgetStore;

namespace OsaGadgetStore
{
    public class Program
    {
     

        public static void Main(string[] args)
        {
           Console.WriteLine("Welcome to Gadget Store");

            Console.WriteLine("Press 1 to shop, Press 2 to view your order,Press 3 to Exit");

           string response = Console.ReadLine();

            Inventory inventory = new Inventory();
            var result = inventory.GetAllInventory();


            if (response == "1")
            {

            }
            else if (response == "2")
            {

            }


        }
    }
}
