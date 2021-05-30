using System.ComponentModel.DataAnnotations;

namespace AutoServiceApp.Model.Entities
{
    class Employee : Person
    {
        public int EmployeeId { get; set; }
        public int SpecialityId { get; set; }
        [Required]
        [RegularExpression(@"^\D*$", ErrorMessage = "Поле ФИО не должно содержать числа")]
        [StringLength(150, MinimumLength = 10, ErrorMessage = "Поле ФИО должно быть не менее 10 символов и не более 150")]
        public override string FIO { get; set; }

        public Speciality Speciality { get; set; }
        public override string Display()
        {
            return "Имя сотрудника: " + FIO;
        }
    }
}
