using SchoolBridge.Domain.Common.Entities;

namespace SchoolBridge.Domain.Entities;

/// <summary>
/// Represents the comment entity in the system.
/// </summary>
public class Comment : AuditableEntity
{
    /// <summary>
    /// Gets or sets the review of the comment.
    /// </summary>
    public string Review { get; set; }

    /// <summary>
    /// Gets or sets the user of the comment.
    /// </summary>
    public Guid FromUserId { get; set; }

    /// <summary>
    /// Gets or sets the class which this comment is for.
    /// </summary>
    public Guid ToClassId { get; set; }

    /// <summary>
    /// Gets or sets the teacher which this comment is for.
    /// </summary>
    public Guid ToTeacherId { get; set; }

    /// <summary>
    /// Gets or sets some feedback about the school.
    /// </summary>
    public string? AboutSchool {  get; set; }

    /// <summary>
    /// Gets or stes the value which determines if the user's comment is anonymous or not.
    /// </summary>
    public bool IsAnonymous { get; set; }
}
