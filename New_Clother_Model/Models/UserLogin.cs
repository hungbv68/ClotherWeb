using System;
using System.Collections.Generic;

namespace New_Clother_Model.Models
{
    public partial class UserLogin
    {
        public string UserId { get; set; } = null!;
        public string UserGroupId { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string UserPassword { get; set; } = null!;
        public string EmployeeId { get; set; } = null!;
        public string OrganizationId { get; set; } = null!;
        public short FirstLogin { get; set; }
        public string UserType { get; set; } = null!;
        public DateTime ChangepassDate { get; set; }
        public short Active { get; set; }
    }
}
