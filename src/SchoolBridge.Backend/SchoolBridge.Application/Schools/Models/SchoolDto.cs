namespace SchoolBridge.Application.Schools.Models;

/// <summary>
/// Represents a data transfer object (DTO) for a school.
/// </summary>
public class SchoolDto
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
}
