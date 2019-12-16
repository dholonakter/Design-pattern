namespace ComputerStore_WPF.Interfaces
{
    public interface iStorage
    {
        string GetDescription();
        void SetCapacity(int capacity);
        decimal GetPrice();
    }
}
