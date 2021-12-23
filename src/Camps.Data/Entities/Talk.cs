using Redis.OM.Modeling;

namespace Camps.Data.Entities;

/// <summary>
/// Entity for the Talks in the camp.
/// </summary>
[Document(StorageType = StorageType.Json)]
public class Talk
{
    /// <summary>
    /// Gets or sets Talk ID.
    /// </summary>
    [RedisIdField]
    public string TalkId { get; set; } = null!;

    /// <summary>
    /// Gets or Sets Camp ID.
    /// </summary>
    [Indexed]
    public string? CampId { get; set; }

    /// <summary>
    /// Gets or sets Title of Talk.
    /// </summary>
    [Indexed]
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
    public Speaker? Speaker { get; set; }
}