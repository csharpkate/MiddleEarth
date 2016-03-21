using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Domain.Entities
{
	public class MiddleEarthContext : DbContext
	{
		public MiddleEarthContext() : base("MiddleEarthContext")
		{
			
		}

		public DbSet<Race> Races { get; set; }
		public DbSet<Region> Regions { get; set; }

		public DbSet<Character> Characters { get; set; }

		public virtual void Commit()
		{
			SaveChanges();
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			Database.SetInitializer<MiddleEarthContext>(new CreateDatabaseIfNotExists<MiddleEarthContext>());
			Database.SetInitializer(new CharacterInitializer());
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}