// <copyright file="DatabaseSeeder.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Camps.Data.Entities;
using Redis.OM;

namespace Camps.Data;

/// <summary>
/// Seeds the Database for the Initial Time.
/// Will add a Migration Logic here.
/// </summary>
public class DatabaseSeeder
{
    private readonly RedisConnectionProvider _redisConnectionProvider;

    /// <summary>
    /// Initializes a new instance of the <see cref="DatabaseSeeder"/> class.
    /// Seeds the Database with the initial value.
    /// </summary>
    /// <param name="redisConnectionProvider">Connection to the Database.</param>
    public DatabaseSeeder(RedisConnectionProvider redisConnectionProvider)
    {
        _redisConnectionProvider = redisConnectionProvider;
    }

    /// <summary>
    /// Method to create a Index.
    /// Possible use it to Scan the assembly and create
    /// the Index.
    /// </summary>
    /// <returns>Status of the Index Creation Process.</returns>
    public bool CreateIndex()
    {
        return false;
    }

    /// <summary>
    /// Seeds the Initial Data for the process.
    /// We need to check the version from Redis
    /// Before we can run the Seed Data.
    /// </summary>
    /// <returns>Status of the seeded Data.</returns>
    public bool SeedData()
    {
        var speakerCollection = _redisConnectionProvider.RedisCollection<Speaker>();
        IList<Speaker> speakers = new List<Speaker>
        {
            new Speaker
            {
                BlogUrl = "http://wildermuth.com",
                Company = "Wilder Minds LLC",
                CompanyUrl = "http://wilderminds.com",
                FirstName = "Shawn",
                LastName = "Wildermuth",
                GitHub = "shawnwildermuth",
                Twitter = "shawnwildermuth",
            },

            new Speaker
            {
                BlogUrl = "http://shawnandresa.com",
                Company = "Wilder Minds LLC",
                CompanyUrl = "http://wilderminds.com",
                FirstName = "Resa",
                LastName = "Wildermuth",
                GitHub = "resawildermuth",
                Twitter = "resawildermuth",
            },
        };
        return false;
    }

    /// <summary>
    /// Clean up the Database after the run.
    /// This is just a demo only feature.
    /// Will be disable in sometime.
    /// </summary>
    /// <returns>Status of the clean up.</returns>
    public bool CleanUp()
    {
        return false;
    }
}