using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace MoviesDB
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Description { get; set; } = "No description added";
    }
}
