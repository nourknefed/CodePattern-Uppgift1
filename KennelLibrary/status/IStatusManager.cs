using KennelLibrary.animal;

namespace KennelLibrary.status
{
    public interface IStatusManager
    {
        decimal DurationCost { get; set; }
        
        void CheckOut(IAnimal animalname);

        decimal GetDuration();

        void CheckIn(IAnimal animalname);
        
    }
}