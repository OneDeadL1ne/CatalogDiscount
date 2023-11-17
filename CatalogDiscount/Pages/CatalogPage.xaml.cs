using static CatalogDiscount.Models.ProductClass;
using CatalogDiscount.Models;
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

namespace CatalogDiscount.Pages
{
    /// <summary>
    /// Логика взаимодействия для CatalogPage.xaml
    /// </summary>
    public partial class CatalogPage : Page
    {
        List<ProductClass> products = new List<ProductClass>();
        public CatalogPage()
        {
            InitializeComponent();
            products.Add(new ProductClass("Холодильник", 20000, null, "Добавить"));

            lv_Products.ItemsSource = products;
        }

        private void btn_AddToCart_Click(object sender, RoutedEventArgs e)
        {
            var product = (ProductClass)((Button)sender).DataContext;
            product.AddCart = "Удалить";
            CartProduct.Add(product);
            
        }
    }
}
