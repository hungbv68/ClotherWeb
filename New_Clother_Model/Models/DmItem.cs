using System;
using System.Collections.Generic;

namespace New_Clother_Model.Models
{
    public partial class DmItem
    {
        public string ItemId { get; set; } = null!;
        public string ItemName { get; set; } = null!;
        public string ItemTypeId { get; set; } = null!;
        public short Acrive { get; set; }
    }
}
