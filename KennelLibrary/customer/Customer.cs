
using KennelLibrary.animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelLibrary.customer
{
    
    public class Customer : ICustomer
    {
        public delegate Customer factory(string FirstName, string LastName);

        public Customer(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            
        }

        public Customer()
        {

        }

       

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => FirstName + LastName;

     
        

    }
}
