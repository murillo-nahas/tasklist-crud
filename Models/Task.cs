namespace TaskApi.Models;

public class Task
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }   
}