using SchoolBridge.Application.Comments.Models;
using SchoolBridge.Domain.Common.Queries;

namespace SchoolBridge.Application.Comments.Queries;

/// <summary>
/// Represents a query to retrieve a specific comment by its ID.
/// </summary>
public record CommentGetByIdQuery : IQuery<CommentDto?>
{
    /// <summary>
    /// The uniqueidentifier of the comment to retrieve.
    /// </summary>
    public Guid CommetId { get; set; }
}
