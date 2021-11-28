using KennelLibrary.menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelLibrary.customer
{

    public class CustomerManager : ICustomerManager
    {
        private readonly Customer.factory _customerfactory;
        private IUserInputOutput _inputOut;
        List<Customer> customers = new List<Customer>();

        public CustomerManager( IUserInputOutput inputOut, Customer.factory customerfactory)
        {
            _customerfactory = customerfactory;
            _inputOut = inputOut;
        }



        public Customer CreateCustomer()
        {
            return new Customer();
        }

        public void AddCustomer()
        {
            

            _inputOut.Log("Please Enter your Name");

            _inputOut.Log("FirstName:");
             var FirstName = _inputOut.GetStringValue();
    
            _inputOut.Log("LastName:");
            var LastName = _inputOut.GetStringValue();

          
            customers.Add(_customerfactory(FirstName, LastName));
        }

        public void ShowAllCustomers()
        {
            _inputOut.Log("------------List Of Customers------------");

            foreach (var cus in customers)
            {
                Console.WriteLine(cus.FullName);
            }
        }


        public void GetlastCustomer()
        {
            var lastCustomer = customers[customers.Count - 1];
            Console.WriteLine(lastCustomer.FirstName);

        }



    }
}
