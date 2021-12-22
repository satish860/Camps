namespace Camps.Data;

/// <summary>
/// Seeds the Database for the Initial Time.
/// Will add a Migration Logic here.
/// </summary>
public class DatabaseSeeder
{
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