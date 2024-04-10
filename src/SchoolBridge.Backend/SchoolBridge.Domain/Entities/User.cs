using SchoolBridge.Domain.Common.Entities;
using SchoolBridge.Domain.Enums;
using System;

namespace SchoolBridge.Domain.Entities;

/// <summary>
/// Represents  abstract base class for user entities in the system.
/// </summary>
public abstract class User : AuditableEntity
{
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
    /// Navigation property that stores the School related to this user.
    /// </summary>
    public School School { get; set; }

}
