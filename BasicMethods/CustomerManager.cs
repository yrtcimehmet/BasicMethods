using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMethods
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Added: " + customer.Name + "Customer Id : " + customer.Id);
        }

        public void Remove(Customer customer)
        {
            Console.WriteLine("Customer with id " + customer.Id+ " has Been Removed" );
        }

        public void list(Customer customer)
        {
            Console.WriteLine("Customer Name : " +customer.Name + " Customer Id: " + customer.Id);
        }
    }
}
