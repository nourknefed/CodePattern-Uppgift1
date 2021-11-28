using System.Collections.Generic;

namespace KennelLibrary.customer
{
    public interface ICustomerManager
    {
        

        Customer CreateCustomer();
        void AddCustomer();
        void ShowAllCustomers();
        void GetlastCustomer();
    }
}