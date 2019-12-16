using ComputerStore_WPF.Interfaces;

namespace ComputerStore_WPF.ComputerShop.Computer
{
    class Laptop : iComputer
    {
        private decimal _price = 399;
        private string _description= "New XPS Dell Laptop\n" +
                                    "* 8th Generation Intel® Core™ i7-8565U Processor \n" +
                                    "* Windows 10 Home";
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
