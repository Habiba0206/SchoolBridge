using SchoolBridge.Application.Classes.Models;
using SchoolBridge.Domain.Common.Commands;

namespace SchoolBridge.Application.Classes.Commands;

/// <summary>
/// Represents a command to modify an existing class.
/// </summary>
public record ClassUpdateCommand : ICommand<ClassDto>
{
    /// <summary>
    /// The data required to update an existing class.
    /// </summary>
    public ClassDto ClassDto { get; set; }
}
