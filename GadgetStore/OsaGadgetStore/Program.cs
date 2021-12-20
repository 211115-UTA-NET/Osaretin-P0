using OsaGadgetStore;

namespace OsaGadgetStore
{
    public class Program
    {
        // separate parts of the code that have their own distinct purposes
        // from each other

        // five design principles: SOLID
        // S: single responsibility principle
        //   each class should have "one responsibility" (not several)
        //   each class should have "one reason to change"
        // we can apply the same idea at many scales: variable, method, project, apps/deployments

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Osa Gadget Store");

            Console.WriteLine("Press 1 to shop, Press 2 to view your order,Press 3 for Admin");

           string response = Console.ReadLine();

            Inventory inventory = new Inventory();

            var result = inventory.GetInv();

             if (response == "1")
            {

            }
            else if(response == "2")
            {

            }


        }
    }
}
