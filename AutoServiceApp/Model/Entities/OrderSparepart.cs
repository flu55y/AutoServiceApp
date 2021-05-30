using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceApp.Model.Entities
{
    class OrderSparepart
    {
        public int OrderSparepartId { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int SparepartId { get; set; }

        public Order Order { get; set; }
        public Sparepart Sparepart { get; set; }
    }
}
