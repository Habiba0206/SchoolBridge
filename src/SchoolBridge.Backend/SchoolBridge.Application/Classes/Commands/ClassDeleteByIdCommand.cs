using SchoolBridge.Domain.Common.Commands;

namespace SchoolBridge.Application.Classes.Commands;

/// <summary>
/// Represents a command to delete an existing class.
/// </summary>
public record ClassDeleteByIdCommand : ICommand<bool>
{
    /// <summary>
    /// The unique identifier of the class to be deleted
    /// </summary>
    public Guid ClassId { get; set; }
}
