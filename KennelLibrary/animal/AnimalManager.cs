using KennelLibrary.customer;
using KennelLibrary.menu;
using KennelLibrary.service;
using KennelLibrary.status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelLibrary.animal
{
    public class AnimalManager : IAnimalManager
    {
        private IUserInputOutput _inputOut;
        private ICustomerManager _customer;
        private IStatusManager _status;
        private IAnimalServiceManager _animalServiceManager;


        // use delegate
        private readonly Animal.factory _animalfactory;
        private readonly Customer.factory _customerfactory;

        Animal animal = new Animal();
        List<Animal> animals = new List<Animal>();
        List<Customer> customers = new List<Customer>();


        
        Status status = new();


        public AnimalManager(Animal.factory animalfactory, IUserInputOutput inputOut,
            ICustomerManager customer, Customer.factory customerfactory, IStatusManager status, IAnimalServiceManager animalServiceManager)
        {
            _animalfactory = animalfactory;
            _inputOut = inputOut;
            _customer = customer;
            _customerfactory = customerfactory;
            _status = status;
            _animalServiceManager = animalServiceManager;
            animal.services = new();

        }


        public Animal CreateAnimal(string Name, string Type, ICustomer customer)
        {
            return new Animal(Name, Type, customer);
        }

        //Add new Customer
        public void AddCustomer()
        {


            _inputOut.Log("Please Enter The Owner Name");
            _inputOut.Log("FirstName:");
            var FirstName = _inputOut.GetStringValue();

            _inputOut.Log("LastName:");
            var LastName = _inputOut.GetStringValue();
            customers.Add(_customerfactory(FirstName, LastName));
        }


        //Add new Animal
        public void RegisterAnimal()
        {
          
            _inputOut.Log("Please Enter your Animal name");

            var Name = _inputOut.GetStringValue();

            _inputOut.Log("Please Enter your Animal Type");

            var Type = _inputOut.GetStringValue();

           

            //get the last customer
            var lastCustomer = customers[customers.Count - 1];

            animals.Add(_animalfactory(Name, Type, lastCustomer));

            
        }

        // show all animals with thier owner
        public void ShowAllAnimals()
        {
            _inputOut.Log("------------List Of Animals------------");

            foreach (var animal in animals)
            {
                Console.WriteLine($" Name: {animal.Name} ......Type:{animal.Type}.........Owner: {animal.CustomerName.FullName}:");

            }


        }


        // check in an animal
        public void AnimalCheckIn(string animalname)
        {
            _inputOut.Log("Please Enter the animal name you want to ckeck in");
            animalname = Console.ReadLine();
            var foundanimal = animals.Find(x => x.Name.Contains(animalname));
          
            if (foundanimal == null)
            {
                Console.WriteLine("Animal notfound");
            }
            else
            {
                 _status.CheckIn(animalname);

            }

        }

        // check out an animal
        public void AnimalCheckOut(string animalname)
        {
            _inputOut.Log("Please Enter the animal name you want to ckeck Out");
            animalname = Console.ReadLine();
            var foundanimal = animals.Find(x => x.Name.Contains(animalname));

            if (foundanimal == null)
            {
                Console.WriteLine("Animal notfound");
            }
            else
            {
                _status.CheckOut(animalname);
               
            }

        }

        //get duration cost
        public void durationcost()
        {
            _status.GetDuration();
        }

        // add clean to an animal
        public void Clean()
        {

            _animalServiceManager.AddCleanService();
           

        }

        // add clawclipping to an animal
        public void ClawClipping()
        {
            _animalServiceManager.AddClawClippingService();

        }

        // get services cost to an animal
        public void GetServicesCosts()
        {
            _animalServiceManager.GetSumOfServices();
        }

        // get all costs to an animal
        public decimal ClaculateCosts()
        {
            decimal total = _animalServiceManager.GetSumOfServices() + _status.GetDuration();

            Console.WriteLine($" The Toltal Cost Is :  -----------------> {total} $");

            return total;

        }


    }

}