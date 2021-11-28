using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelLibrary.menu
{
    public class MenuItem : IMenuItem
    {
        List<string> menuItems = new();

        



        public void CreateMenuItem(string item)
        {
            menuItems.Add(item);
        }

        public void ShowMenu()
        {
            foreach(var item in menuItems)
            {
                Console.WriteLine(item);
            }
        }
  
    }
}
