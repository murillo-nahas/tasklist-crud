using Microsoft.EntityFrameworkCore;

namespace TaskApi.Models;

public class TaskContext : DbContext
{
    public TaskContext(DbContextOptions options) : base(options)
    {}
    public DbSet<Task> Tasks { get; set; } = null!;
}