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
        _redisConnectionProvider.Connection.CreateIndex(typeof(Camp));
        _redisConnectionProvider.Connection.CreateIndex(typeof(Talk));
        _redisConnectionProvider.Connection.CreateIndex(typeof(Speaker));
        return true;
    }

    /// <summary>
    /// Seeds the Initial Data for the process.
    /// We need to check the version from Redis
    /// Before we can run the Seed Data.
    /// </summary>
    /// <returns>Status of the seeded Data.</returns>
    public async Task<bool> SeedData()
    {
        var talkCollection = _redisConnectionProvider.RedisCollection<Talk>();
        IList<Talk> talks = new List<Talk>
        {
            new Talk
            {
                Abstract = "Entity Framework from scratch in an hour. Probably cover it all",
                Level = 100,
                Title = "Entity Framework From Scratch",
                Speaker = new Speaker
                {
                    BlogUrl = "http://wildermuth.com",
                    Company = "Wilder Minds LLC",
                    CompanyUrl = "http://wilderminds.com",
                    FirstName = "Shawn",
                    LastName = "Wildermuth",
                    GitHub = "shawnwildermuth",
                    Twitter = "shawnwildermuth",
                },
            },
            new Talk
            {
                Abstract = "Thinking of good sample data examples is tiring.",
                Level = 200,
                Title = "Writing Sample Data Made Easy",
                Speaker = new Speaker
                {
                    BlogUrl = "http://shawnandresa.com",
                    Company = "Wilder Minds LLC",
                    CompanyUrl = "http://wilderminds.com",
                    FirstName = "Resa",
                    LastName = "Wildermuth",
                    GitHub = "resawildermuth",
                    Twitter = "resawildermuth",
                },
            },
        };
        List<Task> tasks = new List<Task>();
        foreach (var talk in talks)
        {
            tasks.Add(talkCollection.InsertAsync(talk));
        }

        await Task.WhenAll(tasks);
        List<string> talkIds = new List<string>();
        foreach (var task in tasks)
        {
            var result = ((Task<string>)task).Result;
            talkIds.Add(result);
        }

        var camps = _redisConnectionProvider.RedisCollection<Camp>();
        var camp =
            new Camp
            {
                Name = "Atlanta Code Camp",
                EventDate = new DateTime(2018, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                Length = 1,
                Moniker = "ATL2018",
                Talks = talkIds,
                Location = new Location
                {
                    Address1 = "123 Main Street",
                    CityTown = "Atlanta",
                    Country = "USA",
                    PostalCode = "12345",
                    StateProvince = "GA",
                    VenueName = "Atlanta Convention Center",
                },
            };
        var campId = await camps.InsertAsync(camp);
        foreach (var talk in talks)
        {
            talk.CampId = campId;
            await talkCollection.InsertAsync(talk);
        }

        return true;
    }

    /// <summary>
    /// Clean up the Database after the run.
    /// This is just a demo only feature.
    /// Will be disable in sometime.
    /// </summary>
    /// <returns>Status of the clean up.</returns>
    public bool CleanUp()
    {
        _redisConnectionProvider.Connection.Execute("FLUSHDB");
        return true;
    }
}