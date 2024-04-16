using SchoolBridge.Application.Comments.Models;
using SchoolBridge.Domain.Common.Queries;

namespace SchoolBridge.Application.Comments.Queries;

/// <summary>
/// Represents a query to retrieve the collection of comment by its filter.
/// </summary>
public record CommentGetQuery : IQuery<ICollection<CommentDto>>
{
    /// <summary>
    /// The filter pagination to retrieve the collection of comment entities.
    /// </summary>
    public CommentFilter CommentFilter { get; set; }
}
