using System.ComponentModel.DataAnnotations;

namespace MvcLibrary.Models
{
    public class Present
    {
        public int id {  get; set; }

        [Required(ErrorMessage = "Это обязательное поле")]
        [StringLength(15)]
        [Display(Name = "Имя издательства")]
        public string? Name_Present { get; set; }


        [Required(ErrorMessage = "Это обязательное поле")]
        [RegularExpression(@"^[А-Я]+[а-яА-Я0-9""'\s-]*$", ErrorMessage = "Название города должно начинаться с прописной буквы")]
        [StringLength(25)]
        [Display(Name = "Место расположения")]
        public string? Geo_City { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
