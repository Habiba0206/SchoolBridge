namespace SchoolBridge.Application.Classes.Models;

/// <summary>
/// Represents a data transfer object (DTO) for a class.
/// </summary>
public class ClassDto
{
    /// <summary>
    /// Gets or sets the unique identifier of the class. 
    /// </summary>
    public Guid Id { get; set; }

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
}
