using SchoolBridge.Application.Comments.Models;
using SchoolBridge.Domain.Common.Commands;

namespace SchoolBridge.Application.Comments.Commands;

/// <summary>
/// Represents a command to create a new comment.
/// </summary>
public record CommentCreateCommend : ICommand<CommentDto>
{
    /// <summary>
    /// The data required to create a new comment.
    /// </summary>
    public CommentDto CommentDto { get; set; }
}
