using System;
using System.Collections.Generic;

namespace New_Clother_Model.Models
{
    public partial class DmColor
    {
        public string ColorId { get; set; } = null!;
        public string ColorName { get; set; } = null!;
        public short Active { get; set; }
    }
}
