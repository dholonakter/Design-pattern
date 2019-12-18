using ComputerStore_WPF.Interfaces;

namespace ComputerStore_WPF.ComputerShop.Computer
{
    class Desktop : iComputer
    {
        private decimal _price = 2933;
        private string _description = "New Precision 7920 Tower \n" +
                                      "* Intel® Xeon Platinum 8280M Processor \n" +
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
