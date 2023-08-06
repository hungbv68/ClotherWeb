using System;
using System.Collections.Generic;

namespace New_Clother_Model.Models
{
    public partial class Product
    {
        public string PrKey { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public string Image { get; set; } = null!;
        public DateTime DateCreate { get; set; }
        public DateTime DateModify { get; set; }
        public string Status { get; set; } = null!;
        public short Active { get; set; }
    }
}
