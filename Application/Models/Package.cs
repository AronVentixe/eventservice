namespace Application.Models;

public class Package
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public decimal? Price { get; set; }
    public string Currency { get; set; } = string.Empty;

    public string SeatingArrangement { get; set; } = string.Empty;
    public string Placement { get; set; } = string.Empty;
}
