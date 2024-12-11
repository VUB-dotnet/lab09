namespace ExamsApp.Models;

public class Exam {
    public int Id { get; set; }
    public string? IdentityUserId { get; set; }
    public string Name { get; set; }
    public DateTime HappeningAt { get; set; }
    public string Hall { get; set; }
}