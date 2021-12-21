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
            Console.WriteLine("Welcome to Gadget Store");

            Console.WriteLine("Press 1 to shop, Press 2 to view your order,Press 3 for Admin");

            //  string response = Console.ReadLine();


            //  if (response == "1")
            // {
            Inventory inventory = new Inventory();


            List<MyData> result= inventory.GetAllInventory();


            // foreach (var student in result)
            //  Console.WriteLine(student. + ", " + student.Name);

            // Console.WriteLine(result.GetType().GetGenericArguments()[0]);

            int i = 1;
            foreach (var item in result)
            {
                //trying to access index 1 - looks right at first doesn't it??
                Console.WriteLine(i+") Item: "+item.getName()+" Price: $"+item.getPrice()+" Location: "+item.getLocation());
                i++;
                    }

            //add to cart
            Console.WriteLine(result[1].getName());

            //result.
            //  }

            // else if(response == "2")
            // {

            //  }



        }
    }
}
