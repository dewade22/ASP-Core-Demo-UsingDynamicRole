﻿using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models
{
    public partial class AspNetUserClaims
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
    }
}
