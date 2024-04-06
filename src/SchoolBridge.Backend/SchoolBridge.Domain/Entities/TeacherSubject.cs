using SchoolBridge.Domain.Common.Entities;

namespace SchoolBridge.Domain.Entities;

/// <summary>
/// Represents a linking table between `User` (if its role is Teacher) and `Subject` entities
/// This entity is used to establish many-to-many relationship.
/// </summary>
public class TeacherSubject : AuditableEntity
{
    /// <summary>
    /// Gets or sets unique identifier of the associated Teacher.
    /// </summary>
    public Guid TeacherId { get; set; }

    /// <summary>
    /// Gets or sets unique identifier of the associated Subject.
    /// </summary>
    public Guid SubjectId { get; set; }

    /// <summary>
    /// Gets or sets associated Teacher with this entity.
    /// </summary>
    public User Teacher { get; set; }

    /// <summary>
    /// Gets or sets associated Subject with this entity.
    /// </summary>
    public Subject Subject { get; set; }
}
