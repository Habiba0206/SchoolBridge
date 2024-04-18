using SchoolBridge.Domain.Common.Commands;

namespace SchoolBridge.Application.Students.Commands;

/// <summary>
/// Represents a command to delete an existing student.
/// </summary>
public class StudentDeleteByIdCommand : ICommand<bool>
{
    /// <summary>
    /// The unique identifier of the student to be deleted
    /// </summary>
    public Guid StudentId { get; set; }
}
