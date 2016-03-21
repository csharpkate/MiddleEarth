using Domain.Entities;
using Domain.Infrastructure;

namespace Domain.Repositories
{
	public class RaceRepository : RepositoryBase<Race>, IRaceRepository
	{
		public RaceRepository(IDbFactory dbFactory)
			: base(dbFactory)
		{
		}
	}

	public interface IRaceRepository : IRepository<Race>
	{
	}
}