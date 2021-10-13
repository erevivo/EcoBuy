using System.ComponentModel;

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
