using KennelLibrary.customer;
using KennelLibrary.service;
using KennelLibrary.status;
using System.Collections.Generic;

namespace KennelLibrary.animal
{
    public  interface IAnimal
    {
        

        ICustomer CustomerName { get; set; }

        string Name { get; set; }

        string Type { get; set; }

        List<IService> services { get; set; }

        IStatus AnimalStatus { get; set; }

        List<IAnimal> Animals { get; set; }
    }
}