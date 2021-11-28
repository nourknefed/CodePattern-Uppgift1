using KennelLibrary;
using KennelLibrary.animal;
using KennelLibrary.customer;
using KennelLibrary.menu;
using KennelLibrary.service;
using KennelLibrary.status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel
{
    public class Application : IApplication
    {

        public IMenuManger _menu;

        public Application(IMenuManger menu)
        {
            _menu = menu;
        }


        public void Run()
        {
            _menu.CreateMenu();

            _menu.Select();
        }

    }
}
