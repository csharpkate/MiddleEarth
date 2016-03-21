using System.Data.Entity.ModelConfiguration;
using Domain.Entities;

namespace Domain.Mappings
{
	public class RegionMap : EntityTypeConfiguration<Region>
	{
		public RegionMap()
		{
			Property(x => x.Name)
				.HasMaxLength(50)
				.IsRequired();
		}
	}
}