using SchoolBridge.Application.Schools.Models;
using SchoolBridge.Domain.Common.Commands;

namespace SchoolBridge.Application.Schools.Commands;

/// <summary>
/// Represents a command to create a new school.
/// </summary>
public class SchoolCreateCommand : ICommand<StudentDto>
{
    /// <summary>
    /// The data required to create a new school.
    /// </summary>
    public SchoolDto SchoolDto { get; set; }
}
