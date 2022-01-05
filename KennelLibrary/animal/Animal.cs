using KennelLibrary.customer;
using KennelLibrary.service;
using KennelLibrary.status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelLibrary.animal
{
    public class Animal : IAnimal
    {
        public delegate Animal factory(string Name, string Type, ICustomer CustomerName);

        public Animal(string Name, string Type, ICustomer CustomerName)
        {
            this.Name = Name;
            this.Type = Type;
            this.CustomerName = CustomerName;
            services = new();
        }
        public Animal()
        {

        }
   


        public string Name { get; set; }

        public string Type { get; set; }

        public ICustomer CustomerName { get; set; }

        public List<IAnimal> Animals { get; set; }

        public List<IService> services { get; set; }

        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }

        public bool IsCheckedIn { get; set; } = false;

       








    


    }
}
