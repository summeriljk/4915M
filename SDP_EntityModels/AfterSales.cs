using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_EntityModels
{
    public class AfterSales
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Type { get; set; } // "return", "exchange", "complaint"
        public string Status { get; set; } // "pending", "processing", "resolved", "rejected"
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
