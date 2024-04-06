using SchoolBridge.Domain.Common.Entities;
using SchoolBridge.Domain.Enums;
using System;

namespace SchoolBridge.Domain.Entities;

/// <summary>
/// Represents user entitiy in the system.
/// </summary>
public class User : AuditableEntity
{
    /// <summary>
    /// Gets or sets the firstname of the user.
    /// </summary>
    public string FirstName { get; set; } = default!;

    /// <summary>
    /// Gets or sets the lastname of the user.
    /// </summary>
    public string LastName { get; set;} = default!;

    /// <summary>
    /// Gets or sets the birth date of the user
    /// </summary>
    public DateTimeOffset BirthDate { get; set; }

    /// <summary>
    /// Gets the age of the user.
    /// </summary>
    public int Age => DateTime.UtcNow.Year - BirthDate.Year;

    /// <summary>
    /// Gets or sets the email address of the user.
    /// </summary>
    public string EmailAddress { get; set; }= default!;

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
    /// Gets or sets the unique identifier of user's class.
    /// This value is nullable, if the user's role is student or the user's role is teacher and has a class, must not be null. But if the user's role is teacher, and doesn't have a class, then this value is null.
    /// </summary>
    public Guid? ClassId { get; set; }

    /// <summary>
    /// Gets or sets the value which determines if the user has a class.
    /// This value is nullable, because if the user's role is teacher, this user might have class, it's not related to students.
    /// </summary>
    public bool? HasClass { get; set; }

    /// <summary>
    /// Gets or sets hashed password of the user.
    /// </summary>
    public string PasswordHash { get; set; } = default!;

    /// <summary>
    /// Navigation property that stores the School related to this user.
    /// </summary>
    public School School { get; set; }

    /// <summary>
    /// Navigation property that stores the class related to this user.
    /// </summary>
    public Class? Class { get; set; }
}
