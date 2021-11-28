using KennelLibrary.animal;

namespace KennelLibrary.status
{
    public interface IStatusManager
    {
        decimal DurationCost { get; set; }
        
        void CheckOut(string animalname);

        decimal GetDuration();

        void CheckIn(string animalname);
        
    }
}