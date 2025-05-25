using Microsoft.AspNetCore.Mvc.Rendering;
using MvcLibrary.Models;
using System.Collections.Generic;

namespace MvcMovie.Models;

public class MovieGenreViewModel
{
    public List<Book>? Books { get; set; }
    public SelectList? Rating { get; set; }
    public string? BookRating { get; set; }
    public string? SearchString { get; set; }
}
