using SchoolBridge.Application.Students.Models;
using SchoolBridge.Domain.Common.Commands;

namespace SchoolBridge.Application.Students.Commands;

/// <summary>
/// Represents a command to create a new student.
/// </summary>
public class StudentCreateCommand : ICommand<StudentDto>
{
    /// <summary>
    /// The data required to create a new student.
    /// </summary>
    public StudentDto StudentDto { get; set; }
}
