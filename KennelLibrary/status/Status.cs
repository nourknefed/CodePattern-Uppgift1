using KennelLibrary.customer;
using KennelLibrary.animal;
using KennelLibrary.status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelLibrary.status
{
    public class Status : IStatus
    {
        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }

        public bool IsCheckedIn { get; set; } = false;

        public bool IsCheckedOut { get; set; } = false;

        public Customer Owner { get; set; }

        public IAnimal animal { get; set; }
        

        public Status()
        {
           
        }
    }
}
