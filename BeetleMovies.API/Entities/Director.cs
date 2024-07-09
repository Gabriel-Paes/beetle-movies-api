namespace BeetleMovies.API;

public class Director
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public ICollection<Movie> Movies { get; set; } = [];

    public Director() { }

    public Director(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
