using System.Data.Entity.ModelConfiguration;
using Domain.Entities;

namespace Domain.Mappings
{
	public class RaceMap : EntityTypeConfiguration<Race>
	{
		public RaceMap()
		{
			Property(x => x.Name)
				.HasMaxLength(50)
				.IsRequired();
		}
	}
}