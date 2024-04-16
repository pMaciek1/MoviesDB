using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace MoviesDB
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string? Description { get; set; }

        public string? DescTrimmed
        {
            get
            {
                if (this.Description?.Length > 50)
                    return this.Description.Substring(0, 50) + "...";
                else
                    return this.Description;
            }
        }
    }
}
