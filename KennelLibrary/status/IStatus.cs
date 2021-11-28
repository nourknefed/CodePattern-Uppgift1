
using KennelLibrary.animal;
using KennelLibrary.customer;
using System;

namespace KennelLibrary.status
{
    public interface IStatus
    {
        IAnimal animal { get; set; }
        DateTime CheckInDate { get; set; }
        DateTime CheckOutDate { get; set; }
        bool IsCheckedIn { get; set; }
        bool IsCheckedOut { get; set; }
        Customer Owner { get; set; }
    }
}