using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EcoBuy.BE
{
    public enum ProductsCategory
    {
        Food,
        Fashion,
        Health,
        Electricity
    }
    // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty ProductsCategory =
        DependencyProperty.Register("ProdCat", typeof(ProductsCategory), typeof(BE.ProductsCategory), new PropertyMetadata(ProductsCategory.Food));



}
