using SchoolBridge.Application.Comments.Models;
using SchoolBridge.Domain.Common.Commands;

namespace SchoolBridge.Application.Comments.Commands;

/// <summary>
/// Represents a command to modify an existing comment.
/// </summary>
public record CommentUpdateCommand : ICommand<CommentDto>
{
    /// <summary>
    /// The data required to update an existing comment.
    /// </summary>
    public CommentDto CommandDto { get; set; }
}
