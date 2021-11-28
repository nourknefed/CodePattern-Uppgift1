namespace KennelLibrary.menu
{
    public interface IUserInputOutput
    {
        string input { get; set; }

        string GetStringValue();
        void Log(string message);
    }
}