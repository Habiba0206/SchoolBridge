using SchoolBridge.Application.Students.Models;
using SchoolBridge.Domain.Common.Queries;

namespace SchoolBridge.Application.Students.Queries;

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
