using SchoolBridge.Application.Schools.Models;
using SchoolBridge.Domain.Common.Queries;

namespace SchoolBridge.Application.Schools.Queries;

/// <summary>
/// Represents a query to retrieve a specific student by its ID.
/// </summary>
public class StudentGetByIdQuery : IQuery<StudentDto?>
{
    /// <summary>
    /// The uniqueidentifier of the student to retrieve.
    /// </summary>
    public Guid StudentId { get; set; }
}
