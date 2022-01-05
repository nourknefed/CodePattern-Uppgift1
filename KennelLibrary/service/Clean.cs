using KennelLibrary.animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelLibrary.service
{
    public class Clean : IClean
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }

        public IAnimal Animal { get; set; }

        public Clean()
        {
           

            Name = "Clean Service";
            Description = "you get your pet clean and pretty";
            Cost = 10m;
        }



    }
}
