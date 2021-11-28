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
        public decimal DurationCost { get; set; }
        private IAnimal _animal;
     
        Status status { get; set; }
        private IUserInputOutput _inputout;

        

        public StatusManager( IUserInputOutput inputout, IAnimal animal)
        {
            _animal = animal;
            _inputout = inputout;
            status = new();
  
        }

        // check in 
        public void CheckIn(string animalname)
        {
            _inputout.Log("Enter CheckIn Date DD/MM/YYYY");
            status.CheckInDate = Convert.ToDateTime(Console.ReadLine());
        
            status.IsCheckedIn = true;
            if (status.IsCheckedIn == true)
            {
                _inputout.Log($"Hi: your animal  {animalname} is CheckedIn in {status.CheckInDate}");
            }
            else
            {
                _inputout.Log("your animal is out");
            }
        }

        // check out
        public void CheckOut(string animalname)
        {
            _inputout.Log("Enter CheckOut Date  DD/MM/YYYY");
            status.CheckOutDate = Convert.ToDateTime(_inputout.GetStringValue());

            status.IsCheckedIn = false;
            if (status.IsCheckedOut == false)
            {
                _inputout.Log($"Hi  your animal {animalname} is Checked Out in {status.CheckOutDate}");

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

            var duration = (status.CheckOutDate - status.CheckInDate).TotalDays;

             DurationCost = Convert.ToDecimal (duration * costperDay);

            _inputout.Log($"Your animal stay with us {duration} days and the cost is {DurationCost} $");

            return DurationCost;

           


        }


       

    }
}
