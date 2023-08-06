using System;
using System.Collections.Generic;

namespace New_Clother_Model.Models
{
    public partial class DmItemType
    {
        public string ItemTypeId { get; set; } = null!;
        public string ItemTypeName { get; set; } = null!;
        public short Active { get; set; }
    }
}
