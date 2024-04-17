using SchoolBridge.Domain.Enums;

namespace SchoolBridge.Application.Schools.Models;

/// <summary>
/// Represents a data transfer object (DTO) for a student.
/// </summary>
public class StudentDto
{
    /// <summary>
    /// Gets or sets the unique identifier of the student. 
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the firstname of the user.
    /// </summary>
    public string FirstName { get; set; } = default!;

    /// <summary>
    /// Gets or sets the lastname of the user.
    /// </summary>
    public string LastName { get; set; } = default!;

    /// <summary>
    /// Gets or sets the birth date of the user
    /// </summary>
    public DateTimeOffset BirthDate { get; set; }

    /// <summary>
    /// Gets the age of the user.
    /// </summary>
    public int Age => DateTime.UtcNow.Year - BirthDate.Year;

    /// <summary>
    /// Gets or sets the phone number of the user.
    /// </summary>
    public string PhoneNumber { get; set; } = default!;

    /// <summary>
    /// Gets or sets the role of the user.
    /// </summary>
    public Role Role { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of user's school.
    /// </summary>
    public Guid SchoolId { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of student's class.
    /// </summary>
    public Guid ClassId { get; set; }
}
