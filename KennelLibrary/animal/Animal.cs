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
        }
        public Animal()
        {

        }
   


        public string Name { get; set; }

        public string Type { get; set; }

        public ICustomer CustomerName { get; set; }

        public IStatus AnimalStatus { get; set; }

        public List<IAnimal> Animals { get; set; }


        public List<IService> services { get; set; }








        //public Animal()
        //{

        //    var clean = new Clean();

        //    //services.Add(clean);


        //}

    
    }
}
