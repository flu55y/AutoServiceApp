using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutoServiceApp.Model.Entities
{
    class Car
    {
        [Key]
        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Поле Номер автомобиля должно быть не менее 5 символов и не более 20")]
        public string CarNumber { get; set; }
        public int OwnerId { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Поле Марка автомобиля должно быть не менее 2 символов и не более 50")]
        public string Mark { get; set; }

        public Owner Owner { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
