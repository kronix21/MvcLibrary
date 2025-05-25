using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Display(Name = "Название")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Длина названия должна быть от 3 до 60 сиволов")]
        [Required(ErrorMessage = "Это обязательное поле")]
        [RegularExpression(@"^[А-Я]+[а-яА-Я0-9""'\s-]*$", ErrorMessage = "Название должно начинаться с прописной буквы")]
        public string? Title { get; set; }

        [Display(Name = "Дата выхода")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 100, ErrorMessage = "Стоимость должны быть в диапозоне от 1 до 100")]
        [Display(Name = "Стоимость")]
        [Required(ErrorMessage = "Это обязательное поле")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[А-Я]+[а-яА-Я0-9""'\s-]*$", ErrorMessage = "Наименование рейтинга должно начинаться с прописной буквы")]
        [StringLength(5)]
        [Display(Name = "Рейтинг")]
        [Required(ErrorMessage = "Это обязательное поле")]
        public string? Rating { get; set; }

        public ICollection<Avtor> Avtors { get; set; } = new List<Avtor>();

        [Display(Name = "Номер издательства")]
        [Required(ErrorMessage = "Это обязательное поле")]
        public int? Present_ID { get; set; }
        public Present? present { get; set; }

    }
}
