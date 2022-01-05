
using KennelLibrary.animal;
using System.Collections.Generic;

namespace KennelLibrary.customer
{
    public interface ICustomer
    {
        string FirstName { get; set; }
        string FullName => FirstName  + LastName;
        string LastName { get; set; }
    }
}