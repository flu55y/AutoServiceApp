using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceApp.Model.Entities
{
    class TypeOfWork
    {
        public int TypeOfWorkId { get; set; }
        [Required]
        [RegularExpression(@"^\D*$", ErrorMessage = "Поле Специальность не должно содержать числа")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "Поле Наименование должно быть не менее 5 символов и не более 150")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^(\d*\.)?\d+$", ErrorMessage = "Поле Стоимость не должно содержать буквы")]
        public decimal Price { get; set; }
        [Required]
        public string Deadline { get; set; }
        [Required]
        public string Gurantee { get; set; }
    }
}
