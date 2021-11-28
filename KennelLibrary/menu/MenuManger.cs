using KennelLibrary.animal;
using KennelLibrary.customer;
using KennelLibrary.status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelLibrary.menu
{
    public class MenuManger : IMenuManger
    {

        public ICustomerManager _customManager;
        public IAnimalManager _animalManager;
        public IStatusManager _StatusManager;
        public IAnimalServiceManager _animalservice;
        public IAnimal _animal;
        public IMenuItem _menuItem;
        string userInput;




        public MenuManger(ICustomerManager customManager, IAnimalManager animalManager, IStatusManager statusManager, IAnimalServiceManager animalservice, IAnimal animal, IMenuItem menuItem)
        {
            _customManager = customManager;
            _animalManager = animalManager;
            _StatusManager = statusManager;
            _animalservice = animalservice;
            _animal = animal;
            _menuItem = menuItem;

        }

        public void CreateMenu()
        {
            Console.WriteLine("     Welcome To Our Kennel      ");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("     Select  an action       ");
            Console.WriteLine("--------------------------------------");
            _menuItem.CreateMenuItem("1:  Register a customer");
            _menuItem.CreateMenuItem("2:  Show all Customers");
            _menuItem.CreateMenuItem("3:  Register an animal");
            _menuItem.CreateMenuItem("4:  Show all animals with their owners");
            _menuItem.CreateMenuItem("5:  Check In an animal");
            _menuItem.CreateMenuItem("6:  Add Clean Service");
            _menuItem.CreateMenuItem("7:  Add Claw clipping Service");
            _menuItem.CreateMenuItem("8:  Check Out an animal");
            _menuItem.CreateMenuItem("9:  See duration cost");
            _menuItem.CreateMenuItem("10:  See Services Cost");
            _menuItem.CreateMenuItem("11:  See the total Costs");
            _menuItem.CreateMenuItem("12:  close the program");



            _menuItem.ShowMenu();
        }

        public void Select()
        {
            bool close = false;

            while (!close)
            {
                string select = Console.ReadLine();


                switch (select)
                {
                    case "1":
                        _customManager.AddCustomer();
                        break;

                    case "2":
                        _customManager.ShowAllCustomers();
                        break;
                    case "3":
                        _animalManager.AddCustomer();
                        _animalManager.RegisterAnimal();
                        break;
                    case "4":
                        _animalManager.ShowAllAnimals();
                        break;
                    case "5":
                        _animalManager.AnimalCheckIn(userInput);
                        break;
                    case "6":
                        _animalManager.Clean();
                        break;
                    case "7":
                        _animalManager.ClawClipping();
                        break;
                    case "8":
                        _animalManager.AnimalCheckOut(userInput);
                        break;
                    case "9":
                        _animalManager.durationcost();
                        break;
                    case "10":
                        _animalManager.GetServicesCosts();
                        break;
                    case "11":
                        _animalManager.ClaculateCosts();
                        break;
                    case "12":
                        Environment.Exit(0);
                        break;

                }

            }


        }


    }
}
