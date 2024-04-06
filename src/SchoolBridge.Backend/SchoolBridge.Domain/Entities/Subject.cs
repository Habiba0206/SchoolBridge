using SchoolBridge.Domain.Common.Entities;

namespace SchoolBridge.Domain.Entities;

/// <summary>
/// Represents the subject entity in the system.
/// </summary>
public class Subject : AuditableEntity
{
    /// <summary>
    /// Gets or sets the name of the subject.
    /// </summary>
    public string Name;
}
