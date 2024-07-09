namespace BeetleMovies.API;

public class Movie
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public int Year { get; set; }
    public int Rating { get; set; }
    public ICollection<Director> Directors { get; set; } = [];

    public Movie() { }

    public Movie(int id, string title, int year, int rating)
    {
        Id = id;
        Title = title;
        Year = year;
        Rating = rating;
    }
}
