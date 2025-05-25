using System.ComponentModel.DataAnnotations;

namespace MvcLibrary.Models
{
    public class Avtor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Это обязательное поле")]
        [RegularExpression(@"^[А-Я]+[а-яА-Я0-9""'\s-]*$", ErrorMessage = "Имя должно начинаться с прописной буквы")]
        [StringLength(15)]
        [Display(Name = "Имя")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Это обязательное поле")]
        [RegularExpression(@"^[А-Я]+[а-яА-Я0-9""'\s-]*$", ErrorMessage = "Фамилия должно начинаться с прописной буквы")]
        [StringLength(30)]
        [Display(Name = "Фамилия")]
        public string? Surename { get; set; }

        [Required(ErrorMessage = "Это обязательное поле")]
        [RegularExpression(@"^[А-Я]+[а-яА-Я0-9""'\s-]*$", ErrorMessage = "Отчество должно начинаться с прописной буквы")]
        [StringLength(25)]
        [Display(Name = "Отчество")]
        public string? Patronymic { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();

    }
}
