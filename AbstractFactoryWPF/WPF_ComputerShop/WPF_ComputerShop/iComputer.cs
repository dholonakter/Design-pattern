

namespace WPF_ComputerShop
{
    abstract class iComputer
    {
        public string Brand;
        public string Model;
        public double Price;

        protected iComputer(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
    }
}
