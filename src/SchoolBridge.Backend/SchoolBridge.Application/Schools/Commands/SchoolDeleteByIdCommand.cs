using SchoolBridge.Domain.Common.Commands;

namespace SchoolBridge.Application.Schools.Commands;

/// <summary>
/// Represents a command to delete an existing school.
/// </summary>
public class SchoolDeleteByIdCommand : ICommand<bool>
{
    /// <summary>
    /// The unique identifier of the school to be deleted
    /// </summary>
    public Guid SchoolId { get; set; }
}
