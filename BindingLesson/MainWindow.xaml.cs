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

namespace BindingLesson
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Product> products;

        public MainWindow()
        {
            InitializeComponent();

            using (var context = new ShopContext())
            {
                products = new ObservableCollection<Product>(context.Products.ToList());
            }

            dataGrid.ItemsSource = products;

            products.Add(new Product
            {
                Name = "Socks",
                Price = 1000,
                Count = 123
            });
        }

        private void OnRowDeleted(object sender, KeyEventArgs e)
        {
            var currentRow = (DataGridRow)dataGrid
                .ItemContainerGenerator
                .ContainerFromIndex(dataGrid.SelectedIndex);
            if (e.Key == Key.Delete && !currentRow.IsEditing)
            {
                //products.RemoveAt(dataGrid.SelectedIndex);
                string data = "";
            }
        }
    }
}
