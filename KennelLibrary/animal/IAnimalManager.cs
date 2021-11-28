using KennelLibrary.customer;

namespace KennelLibrary.animal
{
    public interface IAnimalManager
    {
       // void CreateAnimal();
        void AddCustomer();
        //void CreateCus();
        void RegisterAnimal();
        void ShowAllAnimals();
        void AnimalCheckIn(string animalname);
        void AnimalCheckOut(string animalname);
        void durationcost();
        decimal ClaculateCosts();
        void Clean();
        void ClawClipping();
        void GetServicesCosts();
    }
}