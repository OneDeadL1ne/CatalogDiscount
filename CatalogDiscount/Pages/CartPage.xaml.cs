using CatalogDiscount.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using static CatalogDiscount.Models.ProductClass; 

namespace CatalogDiscount.Pages
{
    /// <summary>
    /// Логика взаимодействия для CartPage.xaml
    /// </summary>
    public partial class CartPage : Page
    {
        public decimal sum = 0;
        public decimal total = 0;
        public bool isPromo = false;
        public CartPage()
        {
            InitializeComponent();

            foreach (var item in CartProduct)
            {
                sum+=Discount(item);

            }
            tb_TotalPrice.Text = sum.ToString();
            lv_Products.ItemsSource = CartProduct;
        }
       
        private void btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            var product = (ProductClass)((Button)sender).DataContext;

            if (!isPromo)
            {
                sum -= product.discount;

                tb_TotalPrice.Text = sum.ToString();
                CartProduct.Remove(product);
                return;
            }

            sum -= product.discount;
            total = Promo(sum);
            tb_TotalPrice.Text = Decimal.Round(total, 2).ToString();
            CartProduct.Remove(product);
            return;

        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tb_Promo.Text == "Введи промокод")
            {
                tb_Promo.Focus();
                tb_Promo.Text = "";
                tb_Promo.Foreground = Brushes.Black;
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tb_Promo.Text == "")
            {
                tb_Promo.Focus();
                tb_Promo.Text = "Введи промокод";
                tb_Promo.Foreground = Brushes.Gray;
            }
        }

        private void btn_Promo_Click(object sender, RoutedEventArgs e)
        {
            if (tb_Promo.Text == "123")
            {
                isPromo = true;
                total = Promo(sum);
                btn_Promo.Visibility = Visibility.Collapsed;
                btn_Cancel.Visibility = Visibility.Visible;
                tb_Promo.IsEnabled = false;
                tb_TotalPrice.Text = Decimal.Round(total, 2).ToString();
            }

         
        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            isPromo = false;
            tb_Promo.Text = "Введи промокод";
            tb_Promo.Foreground = Brushes.Gray;

            btn_Promo.Visibility = Visibility.Visible;
            btn_Cancel.Visibility = Visibility.Collapsed;
            tb_Promo.IsEnabled = true;
            tb_TotalPrice.Text = Decimal.Round(sum, 2).ToString();
        }
    }
}
