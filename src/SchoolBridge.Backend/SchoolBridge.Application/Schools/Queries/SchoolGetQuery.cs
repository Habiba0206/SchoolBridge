using SchoolBridge.Application.Schools.Models;
using SchoolBridge.Domain.Common.Queries;

namespace SchoolBridge.Application.Schools.Queries;

/// <summary>
/// Represents a query to retrieve the collection of school by its filter.
/// </summary>
public class SchoolGetQuery : IQuery<ICollection<SchoolDto>>
{
    /// <summary>
    /// The filter pagination to retrieve the collection of school entities.
    /// </summary>
    public SchoolFilter SchoolFilter { get; set; }
}
