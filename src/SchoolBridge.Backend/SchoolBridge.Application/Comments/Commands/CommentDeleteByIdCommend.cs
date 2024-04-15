using SchoolBridge.Domain.Common.Commands;

namespace SchoolBridge.Application.Comments.Commands;

/// <summary>
/// Represents a command to delete an existing comment.
/// </summary>
public record CommentDeleteByIdCommend : ICommand<bool>
{
    /// <summary>
    /// The unique identifier of the comment to be deleted
    /// </summary>
    public Guid CommentId { get; set; }
}
