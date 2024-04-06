using SchoolBridge.Domain.Common.Entities;

namespace SchoolBridge.Domain.Entities;

/// <summary>
/// Represents school entity in the system.
/// </summary>
public class School : AuditableEntity
{
    /// <summary>
    /// Gets or sets the name of the school.
    /// </summary>
    public string Name { get; set; } = default!;

    /// <summary>
    /// Gets or sets the descripton about the school.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets the rating of the school.
    /// </summary>
    public float Rate { get; set; }

    /// <summary>
    /// Gets or sets the collection of the users related to this school.
    /// </summary>
    public IEnumerable<User> Users { get; set; }
}
