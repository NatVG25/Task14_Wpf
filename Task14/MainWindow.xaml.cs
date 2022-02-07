using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Молоко",
                Image = "Data/milk.jpg",
                Price = 80,
                Category = Categories.Food
            });
            products.Add(new Product()
            {
                ProductName = "Печенье",
                Image = "Data/cake.jpg",
                Price = 60,
                Category = Categories.Food
            });
            products.Add(new Product()
            {
                ProductName = "Миксер",
                Image = "Data/mixer.jpg",
                Price = 500,
                Category = Categories.Appliances
            });
            lstBox.ItemsSource = products;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            products.Add(new Product()
            {
                ProductName = "Телевизор",
                Image = "Data/tv.jpeg",
                Price = 60000,
                Category = Categories.Appliances
            });
        }
    }
}
