using SchoolBridge.Application.Schools.Models;
using SchoolBridge.Domain.Common.Commands;

namespace SchoolBridge.Application.Schools.Commands;

/// <summary>
/// Represents a command to modify an existing school.
/// </summary>
public class SchoolUpdateCommand : ICommand<SchoolDto>
{
    /// <summary>
    /// The data required to update an existing school.
    /// </summary>
    public SchoolDto SchoolDto { get; set; }
}
