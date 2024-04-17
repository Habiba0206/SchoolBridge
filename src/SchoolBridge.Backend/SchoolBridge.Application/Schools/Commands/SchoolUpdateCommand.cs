using SchoolBridge.Application.Schools.Models;
using SchoolBridge.Domain.Common.Commands;

namespace SchoolBridge.Application.Schools.Commands;

/// <summary>
/// Represents a command to modify an existing school.
/// </summary>
public class SchoolUpdateCommand : ICommand<StudentDto>
{
    /// <summary>
    /// The data required to update an existing school.
    /// </summary>
    public StudentDto SchoolDto { get; set; }
}
