﻿using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models
{
    public partial class AspNetUserRoles
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }

        public virtual AspNetRoles Role { get; set; }
    }
}
