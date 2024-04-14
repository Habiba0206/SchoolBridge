using SchoolBridge.Application.Classes.Models;
using SchoolBridge.Domain.Common.Queries;

namespace SchoolBridge.Application.Classes.Queries;

/// <summary>
/// Represents a query to retrieve a specific class by its ID.
/// </summary>
public record ClassGetByIdQuery : IQuery<ClassDto?>
{
    /// <summary>
    /// The uniqueidentifier of the class to retrieve.
    /// </summary>
    public Guid ClassId { get; set; }
}
