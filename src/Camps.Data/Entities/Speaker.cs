using Redis.OM.Modeling;

namespace Camps.Data.Entities;

/// <summary>
/// Speaker of the Talks.
/// </summary>
[Document(StorageType = StorageType.Json)]
public class Speaker
{
    /// <summary>
    /// Gets or Sets Speaker ID.
    /// </summary>
    [RedisIdField]
    public string SpeakerId { get; set; } = null!;

    /// <summary>
    /// Gets or Sets First Name.
    /// </summary>
    public string FirstName { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the Last Name.
    /// </summary>
    public string LastName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the Middle Name.
    /// </summary>
    public string? MiddleName { get; set; }

    /// <summary>
    /// Gets or Sets the company of the speaker.
    /// </summary>
    public string? Company { get; set; }

    /// <summary>
    /// Gets or sets the URL of the company.
    /// </summary>
    public string? CompanyUrl { get; set; }

    /// <summary>
    /// Gets or sets the Blog URL.
    /// </summary>
    public string? BlogUrl { get; set; }

    /// <summary>
    /// Gets or sets the Twitter Handle.
    /// </summary>
    public string? Twitter { get; set; }

    /// <summary>
    /// Gets or sets the Github Handle.
    /// </summary>
    public string? GitHub { get; set; }
}