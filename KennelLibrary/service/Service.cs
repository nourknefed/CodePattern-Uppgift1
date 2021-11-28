using KennelLibrary.animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelLibrary.service
{
    public class Service : IService
    {
        public delegate Service factory(string Name, string Description, decimal Cost);

        public Service(string Name, string Description, decimal Cost)
        {
            this.Name = Name;
            this.Description = Description;
            this.Cost = Cost;
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Cost { get; set; }

        public IAnimal Animal { get; set; }
    }
}
