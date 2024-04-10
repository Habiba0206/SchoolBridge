namespace SchoolBridge.Domain.Entities;

/// <summary>
/// Represents student entity in the system.
/// </summary>
public class Student : User
{
    /// <summary>
    /// Gets or sets the unique identifier of student's class.
    /// </summary>
    public Guid ClassId { get; set; }

    /// <summary>
    /// Navigation property that stores the class related to this student.
    /// </summary>
    public Class Class { get; set; }
}
