using System.ComponentModel.DataAnnotations;

namespace MvcLibrary.Models
{
    public class Avtor
    {
        public int Id { get; set; }

        [Display(Name = "Имя")]
        public string? Name { get; set; }

        [Display(Name = "Фамилия")]
        public string? Surename { get; set; }

        [Display(Name = "Отчество")]
        public string? Patronymic { get; set; }



        public ICollection<Book> Books { get; set; } = new List<Book>();

    }
}
