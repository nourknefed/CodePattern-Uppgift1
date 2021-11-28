namespace KennelLibrary.animal
{
    public interface IAnimalServiceManager
    {
        decimal ServiceCost { get; set; }

        void AddCleanService();

        void AddClawClippingService();

        decimal GetSumOfServices();

        decimal CalculateAllCosts();

    }
}