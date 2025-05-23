using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Display(Name = "Название")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Title { get; set; }

        [Display(Name = "Дата выхода")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 100)]
        [Display(Name = "Стоимость")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[А-Я]+[а-яА-Я0-9""'\s-]*$")]
        [StringLength(5)]
        [Display(Name = "Рейтинг")]
        [Required]
        public string? Rating { get; set; }

        public ICollection<Avtor> Avtors { get; set; } = new List<Avtor>();

        [Display(Name = "Номер издательства")]
        public int? Present_ID { get; set; }
        public Present? present { get; set; }

    }
}
