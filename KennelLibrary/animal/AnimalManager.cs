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
        private IStatusManager _statusManager;
        private IAnimalServiceManager _animalServiceManager;


        // use delegate
        private readonly Animal.factory _animalfactory;
        private readonly Customer.factory _customerfactory;

      
        List<IAnimal> animals = new List<IAnimal>();
        List<ICustomer> customers = new List<ICustomer>();


        
       


        public AnimalManager(Animal.factory animalfactory, IUserInputOutput inputOut,
            ICustomerManager customer, Customer.factory customerfactory, IStatusManager statusManager, IAnimalServiceManager animalServiceManager)
        {
            _animalfactory = animalfactory;
            _inputOut = inputOut;
          
            _customerfactory = customerfactory;
            _statusManager = statusManager;
            _animalServiceManager = animalServiceManager;
       
            

        }


        public IAnimal CreateAnimal(string Name, string Type, ICustomer customer)
        {
            return _animalfactory(Name, Type, customer);
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

            _inputOut.Log("New animal is registered");

            
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
               
                 _statusManager.CheckIn(foundanimal);

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
                _statusManager.CheckOut(foundanimal);
               
            }

        }

        //get duration cost
        public void durationcost()
        {
            _statusManager.GetDuration();
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
            decimal total = _animalServiceManager.GetSumOfServices() + _statusManager.GetDuration();

            Console.WriteLine($" The Total Cost Is :  -----------------> {total} $");

            return total;

        }


    }

}