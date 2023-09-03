using FluentValidation;

namespace TaskApi.Models;

public class TaskValidator : AbstractValidator<Task>
{
    public TaskValidator()
    {
        RuleFor(task => task.Id).NotNull();

        RuleFor(task => task.Name).NotEmpty().MaximumLength(100);

        RuleFor(task => task.IsComplete).NotNull(); 
    }
}