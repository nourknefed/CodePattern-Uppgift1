using KennelLibrary.animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelLibrary.service
{
    public class ClawClipping : IClawClipping
    {
        public string Name { get;set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public IAnimal Animal { get; set; }

        public ClawClipping()
        {
            Name = "Claw Clipping Service";
            Description = "The screws on the trimmer should be facing the pet.";
            Cost = 5m;
        }
    }
}
