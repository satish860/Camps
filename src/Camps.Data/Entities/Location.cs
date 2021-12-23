using Redis.OM.Modeling;

namespace Camps.Data.Entities;

/// <summary>
/// Location of the camp.
/// </summary>
[Document(StorageType = StorageType.Json)]
public class Location
{
    /// <summary>
    /// Gets or Sets the Location ID for the Location.
    /// </summary>
    [RedisIdField]
    public string LocationId { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the Venue Name for the camp.
    /// </summary>
    public string VenueName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the address line 1.
    /// </summary>
    public string Address1 { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the Address Line 2.
    /// </summary>
    public string Address2 { get; set; } = null!;

    /// <summary>
    /// Gets or sets the Address line 3.
    /// </summary>
    public string Address3 { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the City/Town.
    /// </summary>
    public string CityTown { get; set; } = null!;

    /// <summary>
    /// Gets or sets the State Province.
    /// </summary>
    public string StateProvince { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the Postal code for City.
    /// </summary>
    public string PostalCode { get; set; } = null!;

    /// <summary>
    /// Gets or Sets the Country for the Talk.
    /// </summary>
    public string Country { get; set; } = null!;
}