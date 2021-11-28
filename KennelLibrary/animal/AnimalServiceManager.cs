﻿using KennelLibrary.service;
using KennelLibrary.status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelLibrary.animal
{
    public class AnimalServiceManager : IAnimalServiceManager
    {
        // use delegate//
        private readonly Service.factory _servicefactory;
        // use status manager
        private readonly IStatusManager _statusManager;

        //use services
        public decimal ServiceCost { get; set; }
        Clean clean = new();
        ClawClipping clawClipping = new();
     
        private IAnimal _animal;

        public AnimalServiceManager(Service.factory servicefactory, IAnimal animal, IStatusManager statusManager)
        {
            _servicefactory = servicefactory;
            _animal = animal;
            _statusManager = statusManager;
            _animal.services = new();

        }


        // Add Clean service
        public void AddCleanService()
        {   
            _animal.services.Add(_servicefactory(clean.Name,clean.Description, clean.Cost));

            Console.WriteLine("Clean Service is added");
        }

        // Add ClawClipping service
        public void AddClawClippingService()
        {

            _animal.services.Add(_servicefactory(clawClipping.Name, clawClipping.Description, clawClipping.Cost));
            Console.WriteLine("ClawClipping Service is added");

        }

        //Get the services and thier Costs
        public decimal  GetSumOfServices()
        {

            foreach (var service in _animal.services)
            {
                Console.WriteLine($" Service name:{service.Name} --------- service price: {service.Cost} $");
            }

             ServiceCost = _animal.services.Sum(i => i.Cost);

            Console.WriteLine("The Cost of services is: " + ServiceCost + " $");

            return ServiceCost;
        }

        //Calculate All Costs(duration+ services)
        public decimal CalculateAllCosts()
        {
            _statusManager.DurationCost = _statusManager.GetDuration();
            var total = _statusManager.DurationCost + ServiceCost;

            Console.WriteLine("The Tooooooootal is   ------>" + total);

            return total;
        }


    }
}
