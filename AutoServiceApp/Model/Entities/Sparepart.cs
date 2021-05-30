using System.ComponentModel.DataAnnotations;

namespace AutoServiceApp.Model.Entities
{
    class Sparepart
    {
        public int SparepartId { get; set; }
        [Required]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "Поле Наименование должно быть не менее 5 символов и не более 150")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^(\d*\.)?\d+$", ErrorMessage = "Поле Стоимость не должно содержать буквы")]
        public decimal Price { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Поле Гарантия должно быть не менее 1 символа и не более 50")]
        public string Guarantee { get; set; }
    }
}
