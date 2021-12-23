using System.Threading.Tasks;
using Redis.OM;
using Xunit;

namespace Camps.Data.Tests;

public class DatabaseSeederTests
{
    [Fact]
    public async Task Should_be_Able_to_Seed_Camp()
    {
        DatabaseSeeder databaseSeeder = new DatabaseSeeder(new RedisConnectionProvider("redis://localhost:6379"));
        var actual = await databaseSeeder.SeedData();
        Assert.True(actual);
    }

    [Fact]
    public void Should_be_Able_to_List_Index()
    {
        DatabaseSeeder databaseSeeder = new DatabaseSeeder(new RedisConnectionProvider("redis://localhost:6379"));
        var actual =  databaseSeeder.CreateIndex();
        Assert.True(actual);
        databaseSeeder.CleanUp();
    }

    [Fact]
    public void Should_be_Able_to_Clean_Up_Database()
    {
        DatabaseSeeder databaseSeeder = new DatabaseSeeder(new RedisConnectionProvider("redis://localhost:6379"));
        var actual =  databaseSeeder.CleanUp();
        Assert.True(actual);
    }
}