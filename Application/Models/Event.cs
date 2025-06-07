using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models;

public class Event
{

    public string? Id { get; set; }
    public string? Image { get; set; }
    public string? Title { get; set; }
    public DateTime EventDate { get; set; }
    public string? Location { get; set; }
    public string? Description { get; set; }
}
