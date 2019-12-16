using System.Text.RegularExpressions;
using System.Windows;
using ComputerShop;
using ComputerStore_WPF.Interfaces;

namespace ComputerStore_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Shop shop;
        private readonly int[] RAM_Array = new int[6];
        private readonly int[] Storage_Array=new int[7];
        
        
        private void startup()
        {
            clear();
            RAM_Array[0] = 4;
            RAM_Array[1] = 8;
            RAM_Array[2] = 16;
            RAM_Array[3] = 32;
            RAM_Array[4] = 64;
            RAM_Array[5] = 128;

            Storage_Array[0] = 250;
            Storage_Array[1] = 500;
            Storage_Array[2] = 750;
            Storage_Array[3] = 1;
            Storage_Array[4] = 2;
            Storage_Array[5] = 4;
            Storage_Array[6] = 8;

            foreach (var RAM in RAM_Array)
            {
                CmBxRAMdesk.Items.Add(RAM + " GB");
            }

            foreach (var Storage in Storage_Array)
            {
                if (Storage <= 250)
                {
                    CmBxStorageD.Items.Add(Storage + " TB");
                }
                else
                {
                    CmBxStorageD.Items.Add(Storage + " GB");
                }
            }

            for (var i = 0; i < 4; i++)
            {
                CmBxRAMlap.Items.Add(RAM_Array[i] + " GB");
            }

            for (var i = 0; i < 6; i++)
            {
                if (Storage_Array[i] <= 250)
                {
                    CmBxStorageL.Items.Add(Storage_Array[i] + " TB");
                }
                else
                {
                    CmBxStorageL.Items.Add(Storage_Array[i] + " GB");
                }
            }
        }

        private protected void clear()
        {
            RdBtnLaptop.IsChecked = false;
            RdBtnDesktop.IsChecked = false;
            RdBtnLram.IsChecked = false;
            RdBtnDram.IsChecked = false;
            RdBtnLstorage.IsChecked = false;
            RdBtnDstorage.IsChecked = false;
            CmBxRAMlap.Visibility = Visibility.Hidden;
            CmBxRAMdesk.Visibility = Visibility.Hidden;
            CmBxStorageL.Visibility = Visibility.Hidden;
            CmBxStorageD.Visibility = Visibility.Hidden;
            BtnCreate.Visibility = Visibility.Hidden;
            BtnCreateDefault.Visibility = Visibility.Hidden;
            BtnDiscard.Visibility = Visibility.Hidden;
            Lbx.Items.Clear();

            RdBtnDram.IsEnabled = false;
            RdBtnDstorage.IsEnabled = false;
            RdBtnLram.IsEnabled = false;
            RdBtnLstorage.IsEnabled = false;
        }

        public MainWindow()
        {
            InitializeComponent();
            startup();
        }

        private void rButtonChanged(object sender, RoutedEventArgs e)
        {
            if (RdBtnLaptop.IsChecked.Equals(true))
            {
                RdBtnLram.IsChecked = true;
                RdBtnLstorage.IsChecked = true;
                RdBtnLram.IsEnabled = true;
                RdBtnLstorage.IsEnabled = true;
                CmBxRAMlap.Visibility = Visibility.Visible;
                CmBxStorageL.Visibility = Visibility.Visible;
                BtnCreate.Visibility = Visibility.Visible;
                BtnCreateDefault.Visibility = Visibility.Visible;
                BtnDiscard.Visibility = Visibility.Visible;

                CmBxRAMdesk.Visibility = Visibility.Hidden;
                CmBxStorageD.Visibility = Visibility.Hidden;

                RdBtnDram.IsEnabled = false;
                RdBtnDstorage.IsEnabled = false;
            }

            if (RdBtnDesktop.IsChecked.Equals(true))
            {
                RdBtnDram.IsChecked = true;
                RdBtnDstorage.IsChecked = true;
                RdBtnDram.IsEnabled = true;
                RdBtnDstorage.IsEnabled = true;
                CmBxRAMdesk.Visibility = Visibility.Visible;
                CmBxStorageD.Visibility = Visibility.Visible;
                BtnCreate.Visibility = Visibility.Visible;
                BtnCreateDefault.Visibility = Visibility.Visible;
                BtnDiscard.Visibility = Visibility.Visible;

                CmBxRAMlap.Visibility = Visibility.Hidden;
                CmBxStorageL.Visibility = Visibility.Hidden;

                RdBtnLram.IsEnabled = false;
                RdBtnLstorage.IsEnabled = false;
            }
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            var capacityRAM = 0;
            var capacityStorage = 0;
            if (RdBtnLaptop.IsChecked.Equals(true))
            {
                var ramCapacitySearch = Regex.Split(CmBxRAMlap.SelectedItem.ToString(), @"\D+");
                var storageCapacitySearch = Regex.Split(CmBxStorageL.SelectedItem.ToString(), @"\D+");
                foreach (var s in ramCapacitySearch)
                {
                    if (!string.IsNullOrEmpty(s))
                    {
                        capacityRAM = int.Parse(s);
                    }
                }

                foreach (var s in storageCapacitySearch)
                {
                    if (!string.IsNullOrEmpty((s)))
                    {
                        capacityStorage = int.Parse(s);
                    }
                }
                Lbx.Items.Clear();
                iComputerFactory factory = new LaptopFactory();
                shop=new Shop(factory);
                shop.Create(capacityRAM,capacityStorage);
                Lbx.Items.Add(shop.Display());
            }

            if (RdBtnDesktop.IsChecked.Equals(true))
            {
                var ramCapacitySearch = Regex.Split(CmBxRAMdesk.SelectedItem.ToString(), @"\D+");
                var storageCapacitySearch = Regex.Split(CmBxStorageD.SelectedItem.ToString(), @"\D+");
                foreach (var s in ramCapacitySearch)
                {
                    if (!string.IsNullOrEmpty(s))
                    {
                        capacityRAM = int.Parse(s);
                    }
                }

                foreach (var s in storageCapacitySearch)
                {
                    if (!string.IsNullOrEmpty((s)))
                    {
                        capacityStorage = int.Parse(s);
                    }
                }
                Lbx.Items.Clear();
                iComputerFactory factory = new DesktopFactory();
                shop = new Shop(factory);
                shop.Create(capacityRAM, capacityStorage);
                Lbx.Items.Add(shop.Display());
            }
        }

        private void BtnCreateDefault_Click(object sender, RoutedEventArgs e)
        {
            if (RdBtnDesktop.IsChecked.Equals(true))
            {
                Lbx.Items.Clear();
                iComputerFactory factory = new DesktopFactory();
                shop = new Shop(factory);
                Lbx.Items.Add(shop.CreateAndDisplay());
            }

            if (RdBtnLaptop.IsChecked.Equals(true))
            {
                Lbx.Items.Clear();
                iComputerFactory factory=new LaptopFactory();
                shop=new Shop(factory);
                Lbx.Items.Add(shop.CreateAndDisplay());
            }
        }

        private void BtnDiscard_Click(object sender, RoutedEventArgs e)
        {
            clear();
        }
    }
}
