namespace BasicMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer James = new Customer();
            James.Id = 283663;
            James.Name = "James";

            Customer Elizabeth = new Customer();
            Elizabeth.Id = 792548;
            Elizabeth.Name = "Elizabeth";

            Customer David = new Customer();
            David.Id = 525521;
            David.Name = "David";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(James);
            customerManager.Add(Elizabeth);
            customerManager.Add(David);

            customerManager.Remove(James);

            customerManager.list(David);




            Console.WriteLine("Hello, World!");
        }
    }
}