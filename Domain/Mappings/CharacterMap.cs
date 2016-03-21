using System.Data.Entity.ModelConfiguration;
using Domain.Entities;

namespace Domain.Mappings
{
	internal class CharacterMap : EntityTypeConfiguration<Character>
	{
		public CharacterMap()
		{
			Property(x => x.FirstName)
				.HasMaxLength(50)
				.IsRequired();

			Property(x => x.LastName)
				.HasMaxLength(50)
				.IsOptional();

			Property(x => x.Address)
				.HasMaxLength(100)
				.IsOptional();

			Property(x => x.City)
				.HasMaxLength(50)
				.IsRequired();

			Property(x => x.Age)
				.IsOptional();


			Property(x => x.Interests)
				.IsOptional();

			Property(x => x.RaceId)
				.IsRequired();

			Property(x => x.RegionId)
				.IsRequired();
		}
	}
}