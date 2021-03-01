using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoBuy.BE
{
    //public enum ProductsCategory { Food, Fashion, Health, Electricity };
    public enum ProductsCategory
    {
        [Description("מזון")]
        Food,
        [Description("אופנה")]
        Fashion,
        [Description("בריאות וטיפוח")]
        Health,
        [Description("חשמל ואלקטרוניקה")]
        Electricity
    }
}
