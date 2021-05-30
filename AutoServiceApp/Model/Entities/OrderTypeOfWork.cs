using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceApp.Model.Entities
{
    class OrderTypeOfWork
    {
        public int OrderTypeOfWorkId { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int TypeOfWorkId { get; set; }

        public Order Order { get; set; }
        public TypeOfWork TypeOfWork { get; set; }
    }
}
