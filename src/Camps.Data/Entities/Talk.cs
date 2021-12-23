namespace Camps.Data.Entities;

/// <summary>
/// Entity for the Talks in the camp.
/// </summary>
public class Talk
{
    /// <summary>
    /// Gets or sets Talk ID.
    /// </summary>
    public string TalkId { get; set; } = null!;

    /// <summary>
    /// Gets or Sets Camp ID.
    /// </summary>
    public int CampId { get; set; }

    /// <summary>
    /// Gets or sets Title of Talk.
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the Abstract of the Talk.
    /// </summary>
    public string Abstract { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the level of the Talk.
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// Gets or sets the Speaker of the talks.
    /// </summary>
    public int? Speaker { get; set; }
}