using SchoolBridge.Application.Schools.Models;
using SchoolBridge.Domain.Common.Queries;

namespace SchoolBridge.Application.Schools.Queries;

/// <summary>
/// Represents a query to retrieve a specific school by its ID.
/// </summary>
public class SchoolGetByIdQuery : IQuery<SchoolDto?>
{
    /// <summary>
    /// The uniqueidentifier of the school to retrieve.
    /// </summary>
    public Guid SchoolId { get; set; }
}
