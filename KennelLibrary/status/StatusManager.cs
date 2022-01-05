using KennelLibrary.animal;
using KennelLibrary.menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelLibrary.status
{
    public class StatusManager : IStatusManager
    {
       // public readonly Status.factory _statusfactory;
        public decimal DurationCost { get; set; }

        private IAnimal _animal;
        private IUserInputOutput _inputout;


        

        public StatusManager( IUserInputOutput inputout, IAnimal animal)
        {
            _animal = animal;
            _inputout = inputout;
           // _statusfactory = statusfactory;
           
  
        }

        // check in 
        public void CheckIn(IAnimal animal) // skicka in animal objektet eller om du skickar in namnet ta fram animal objektet
        {
            _inputout.Log("Enter CheckIn Date DD/MM/YYYY");
            _animal.CheckInDate = Convert.ToDateTime(Console.ReadLine());
        
            _animal.IsCheckedIn = true;
            if (_animal.IsCheckedIn == true)
            {
                _inputout.Log($"Hi: your {animal.Type} {animal.Name} is CheckedIn in {_animal.CheckInDate}");
            }
            else
            {
                _inputout.Log("your animal is out");
            }
        }

        // check out
        public void CheckOut(IAnimal animal)
        {
            _inputout.Log("Enter CheckOut Date  DD/MM/YYYY");
            _animal.CheckOutDate = Convert.ToDateTime(_inputout.GetStringValue());

            _animal.IsCheckedIn = false;
            if (_animal.IsCheckedIn == false)
            {
                _inputout.Log($"Hi  your {animal.Type} {animal.Name} is Checked Out in {_animal.CheckOutDate}");

            }
            else
            {
                _inputout.Log("your animal is In");
            }
        }

        // get duration
        public decimal GetDuration()
        {
            var costperDay = 20;

            var duration = (_animal.CheckOutDate - _animal.CheckInDate).TotalDays;

             DurationCost = Convert.ToDecimal (duration * costperDay);

            _inputout.Log($"Your animal stay with us {duration} days and the cost is {DurationCost} $");

            return DurationCost;

           


        }


       

    }
}
