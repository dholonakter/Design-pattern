using ComputerStore_WPF.Interfaces;

namespace ComputerStore_WPF.ComputerShop.Computer
{
    class Laptop : iComputer
    {
        private decimal _price = 1850;
        private string _description= "New Precision 7740\n" +
                                    "* 9th Generation Intel® Core™ i9-9980HK Processor \n" +
                                    "* Windows 10 Pro";
        public string GetDescription()
        {
            return _description;
        }
        
        public decimal GetPrice()
        {
            return _price;
        }
    }
}
