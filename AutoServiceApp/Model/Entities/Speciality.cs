using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutoServiceApp.Model.Entities
{
    class Speciality
    {
        public int SpecialityId { get; set; }
        [Required]
        [RegularExpression(@"^\D*$", ErrorMessage = "Поле Специальность не должно содержать числа")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "Поле Специальность должно быть не менее 5 символов и не более 150")]
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
