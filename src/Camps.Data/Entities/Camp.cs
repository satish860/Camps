using Redis.OM.Modeling;

namespace Camps.Data.Entities;

/// <summary>
/// Main Entity for Camp.
/// </summary>
[Document(StorageType = StorageType.Json)]
public class Camp
{
    /// <summary>
    /// Gets or sets camp ID field for storage.
    /// </summary>
    [RedisIdField]
    public string CampId { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the Name of the camp.
    /// </summary>
    [Indexed(Normalize = true)]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets Moniker for the Camp.
    /// </summary>
    [Indexed(Normalize = true)]
    public string Moniker { get; set; } = null!;

    /// <summary>
    /// Gets or sets the Location of the camp.
    /// </summary>
    [Indexed]
    public Location Location { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the Date of Event.
    /// </summary>
    [Indexed]
    public DateTime EventDate { get; set; } = DateTime.MinValue;

    /// <summary>
    /// Gets or sets the Length of the Camp.
    /// </summary>
    public int Length { get; set; } = 1;

    /// <summary>
    /// Gets or Sets Talks. This contains the reference of Talks.
    /// </summary>
    public IList<string>? Talks { get; set; }
}
