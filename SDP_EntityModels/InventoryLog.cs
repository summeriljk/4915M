using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_EntityModels
{
    public class InventoryLog
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ChangeAmount { get; set; }
        public string Reason { get; set; }
        public int AdminId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
