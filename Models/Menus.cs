using System;
using System.Collections.Generic;

namespace Balimoon_E_Procurement.Models
{
    public partial class Menus
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
        public int? ParentId { get; set; }

      
    }
}
