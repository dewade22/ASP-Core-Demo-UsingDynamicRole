﻿using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class CustomerDiscountGroup
    {
        public int CustomerDiscountGroupId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public byte? InfocodeDiscountGroup { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
