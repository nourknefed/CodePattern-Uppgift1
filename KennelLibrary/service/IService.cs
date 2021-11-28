using KennelLibrary.animal;
using System;

namespace KennelLibrary.service
{
    public interface IService
    {
        string Name { get; set; }

        string Description { get; set; }

        decimal Cost { get; set; }

        IAnimal Animal { get; set; }
    }
}