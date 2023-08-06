using System;
using System.Collections.Generic;

namespace New_Clother_Model.Models
{
    public partial class ProductAttribute
    {
        public Guid PrKey { get; set; }
        public string FrKey { get; set; } = null!;
        public string AttributeName { get; set; } = null!;
        public string ColorId { get; set; } = null!;
        public string Size { get; set; } = null!;
        public decimal PriceProduct { get; set; }
        public decimal PriceSale { get; set; }
        public string ItemId { get; set; } = null!;
        public string Status { get; set; } = null!;
        public short Active { get; set; }
    }
}
