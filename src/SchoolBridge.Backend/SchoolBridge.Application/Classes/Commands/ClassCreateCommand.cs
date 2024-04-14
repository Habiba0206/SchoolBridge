using SchoolBridge.Application.Classes.Models;
using SchoolBridge.Domain.Common.Commands;

namespace SchoolBridge.Application.Classes.Commands;

/// <summary>
/// Represents a command to create a new class.
/// </summary>
public record ClassCreateCommand : ICommand<ClassDto>
{
    /// <summary>
    /// The data required to create a new class.
    /// </summary>
    public ClassDto ClassDto { get; set; }
}
