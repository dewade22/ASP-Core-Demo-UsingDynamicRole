﻿using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models.BalimoonBML
{
    public partial class ReasonCode
    {
        public int ReasonCodeId { get; set; }
        public string ReasonCodeGroupNo { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int? HandpointCode { get; set; }
        public short RowStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public string GlaccountNo { get; set; }
    }
}
