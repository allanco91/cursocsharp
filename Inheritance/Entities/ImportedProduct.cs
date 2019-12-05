using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Inheritance.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFree)
            : base(name, price)
        {
            CustomsFee = customsFree;
        }
        
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return $"{Name} $ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} " +
                $"(Customs free: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
