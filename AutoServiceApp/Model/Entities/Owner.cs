using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutoServiceApp.Model.Entities
{
    class Owner : Person
    {
        public int OwnerId { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }

        [Required]
        [RegularExpression(@"^\D*$", ErrorMessage = "Поле ФИО не должно содержать числа")]
        [StringLength(150, MinimumLength = 10, ErrorMessage = "Поле ФИО должно быть не менее 10 символов и не более 150")]
        public override string FIO { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Поле Телефон должно быть не менее 5 символов и не более 20")]
        public string Phone { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Поле Вод. удостоверение должно быть не менее 5 символов и не более 20")]
        public string DriverLicense { get; set; }

        public ICollection<Car> Cars { get; set; }
        public override string Display()
        {
            return "Имя владельца: " + FIO;
        }
    }
}
