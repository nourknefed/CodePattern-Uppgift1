using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelLibrary.menu
{
    public class UserInputOutput : IUserInputOutput
    {
        public string input { get; set; }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public string GetStringValue()
        {
            input = Console.ReadLine();

            return input;

        }


    }
}
