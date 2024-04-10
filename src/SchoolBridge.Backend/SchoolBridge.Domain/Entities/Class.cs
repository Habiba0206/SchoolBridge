using SchoolBridge.Domain.Common.Entities;

namespace SchoolBridge.Domain.Entities;

/// <summary>
/// Represents the class entity in the system.
/// </summary>
public class Class : AuditableEntity
{
    /// <summary>
    /// Gets or sets the name of the class.
    /// </summary>
    public string Name { get; set; } = default!;

    /// <summary>
    /// Gets or sets the degree of the class.
    /// </summary>
    public int Degree { get; set; }

    /// <summary>
    /// Gets or sets the rating of the class.
    /// </summary>
    public float Rate { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the class's head teacher.
    /// </summary>
    public Guid HeadTeacherId { get; set; }

    /// <summary>
    /// Navigation property that stores Teacher user related to this Class.
    /// </summary>
    public Teacher HeadTeacher { get; set; }

    /// <summary>
    /// Gets or sets the collection of the students related to this school.
    /// </summary>
    public IEnumerable<Student> Students { get; set; }
}
