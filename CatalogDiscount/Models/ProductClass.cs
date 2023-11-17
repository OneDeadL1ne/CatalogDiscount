using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogDiscount.Models
{
    public class ProductClass
    {

        public int id { get; set; }
        public string model { get; set; }
        public decimal price { get; set; }
        public decimal discount { get; set; }
        public string pahtitle { get; set; } = string.Empty;    
        public string AddCart { get; set; }

        public ProductClass(string model, int price, string pathtitle, string AddCart) 
        {
            this.model = model;
            this.price = price;
            this.pahtitle = pathtitle;
            this.AddCart = AddCart;
        }
        public static ObservableCollection<ProductClass> CartProduct { get; set; } = new ObservableCollection<ProductClass>();

        public static decimal Discount(ProductClass product)
        {
            if(product.price >=20000)
            {
                product.discount = product.price - (product.price * 0.16m);
            }
            else if (product.price >= 10000)
            {
                product.discount = product.price-(product.price * 0.08m);
            }
            else if (product.price >= 1000)
            {
                product.discount = product.price - (product.price * 0.01m);
            }

            return product.discount;
        }

        public static decimal Promo(decimal sum)
        {
            if (sum >= 20000)
            {
                sum = sum - (sum * 0.10m);
            }
            else if (sum >= 10000)
            {
                sum = sum - (sum * 0.05m);
            }
            else if (sum >= 1000)
            {
                sum = sum - (sum * 0.01m);
            }

            return sum;
        }

    }
}
