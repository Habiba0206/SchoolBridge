using SchoolBridge.Application.Schools.Models;
using SchoolBridge.Domain.Common.Commands;

namespace SchoolBridge.Application.Schools.Commands;

/// <summary>
/// Represents a command to modify an existing student.
/// </summary>
public class StudentUpdateCommand : ICommand<StudentDto>
{
    /// <summary>
    /// The data required to update an existing student.
    /// </summary>
    public StudentDto StudentDto { get; set; }
}
