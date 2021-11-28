
using KennelLibrary.animal;
using System.Collections.Generic;

namespace KennelLibrary.customer
{
    public interface ICustomer
    {
        List<IAnimal> Animals { get; set; }
        string FirstName { get; set; }
        string FullName => FirstName  + LastName;
        string LastName { get; set; }
    }
}