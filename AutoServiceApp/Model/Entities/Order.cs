using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutoServiceApp.Model.Entities
{
    class Order
    {
        public int OrderId { get; set; }
        public int? EmployeeId { get; set; }
        [Required]
        public string CarNumber { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "Поле Причина должно быть не менее 5 символов и не более 200")]
        public string Reason { get; set; }
        [Required]       
        public string Status { get; set; }
        [Required]
        public DateTime Date { get; set; }

        public Car Car { get; set; }
        public Employee Employee { get; set; }
        public ICollection<OrderSparepart> OrderSpareparts { get; set; }
        public ICollection<OrderTypeOfWork> OrderTypeOfWorks { get; set; }
    }
}
