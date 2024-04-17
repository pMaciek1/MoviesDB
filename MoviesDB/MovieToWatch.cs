namespace MoviesDB
{
    public class MovieToWatch
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string? Description { get; set; } = "No description added";
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
