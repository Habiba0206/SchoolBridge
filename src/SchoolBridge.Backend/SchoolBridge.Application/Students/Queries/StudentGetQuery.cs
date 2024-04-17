using SchoolBridge.Application.Schools.Models;
using SchoolBridge.Domain.Common.Queries;

namespace SchoolBridge.Application.Schools.Queries;

/// <summary>
/// Represents a query to retrieve the collection of student by its filter.
/// </summary>
public class StudentGetQuery : IQuery<ICollection<StudentDto>>
{
    /// <summary>
    /// The filter pagination to retrieve the collection of student entities.
    /// </summary>
    public StudentFilter StudentFilter { get; set; }
}
