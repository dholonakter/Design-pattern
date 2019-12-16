using ComputerStore_WPF.Interfaces;

namespace ComputerShop
{
    public class Shop
    {
        private iComputerFactory factory;
        private iComputer computer;
        private iRAM RAM;
        private iStorage storage;

        public Shop(iComputerFactory computerFactory)
        {
            this.factory = computerFactory;
        }

        public string CreateAndDisplay()
        {
            computer = factory.CreateComputer();
            RAM = factory.CreateRAM();
            storage = factory.CreateStorage();
            decimal totalPrice = computer.GetPrice() + RAM.GetPrice() + storage.GetPrice();

            return "Your " + computer.GetDescription() +
                "\n" + RAM.GetDescription() +
                "\n" + storage.GetDescription() +
                "\n* Price: " + totalPrice + ",-";
        }

        public void Create(int ram, int storage)
        {
            computer = factory.CreateComputer();
            RAM = factory.CreateRAM();
            RAM.SetCapacity(ram);
            this.storage = factory.CreateStorage();
            this.storage.SetCapacity(storage);

        }

        public string Display()
        {
            decimal totalPrice = computer.GetPrice() + RAM.GetPrice() + storage.GetPrice();

            return "Your " + computer.GetDescription() +
                   "\n" + RAM.GetDescription() +
                   "\n" + storage.GetDescription() +
                   "\n* Price: " + totalPrice + ",-";
        }
    }
}
