using System.ComponentModel.DataAnnotations;

namespace MvcLibrary.Models
{
    public class Present
    {
        public int id {  get; set; }

        [Display(Name = "Имя издательства")]
        public string? Name_Present { get; set; }

        [Display(Name = "Место расположения")]
        public string? Geo_City { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
