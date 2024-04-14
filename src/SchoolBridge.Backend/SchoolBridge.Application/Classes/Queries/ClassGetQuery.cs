using SchoolBridge.Application.Classes.Models;
using SchoolBridge.Domain.Common.Queries;

namespace SchoolBridge.Application.Classes.Queries;

/// <summary>
/// Represents a query to retrieve the collection of class by its filter.
/// </summary>
public record ClassGetQuery : IQuery<ICollection<ClassDto>>
{
    /// <summary>
    /// The filter pagination to retrieve the collection of class entities.
    /// </summary>
    public ClassFilter ClassFilter { get; set; }
}
