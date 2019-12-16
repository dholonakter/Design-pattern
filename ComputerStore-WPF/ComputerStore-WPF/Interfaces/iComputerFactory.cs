namespace ComputerStore_WPF.Interfaces
{
    public interface iComputerFactory
    {
        iComputer CreateComputer();
        iRAM CreateRAM();
        iStorage CreateStorage();
    }
}
