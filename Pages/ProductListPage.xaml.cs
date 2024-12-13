using PR16.ApplicationData;
using System;
using System.Collections.Generic;
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
using static PR16.ApplicationData.AppDbContext;

namespace PR16
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();

        }




        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var selectedProduct = (Product)ProductGrid.SelectedItem;
            if (selectedProduct != null)
            {
                AppConnect.DbContext.Products.Remove(selectedProduct);


            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}



