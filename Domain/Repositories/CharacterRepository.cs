using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Infrastructure;

namespace Domain.Repositories
{
	public class CharacterRepository : RepositoryBase<Character>, ICharacteryRepository
	{
		public CharacterRepository(IDbFactory dbFactory)
				: base(dbFactory)
		{ }

		public Character GetCharacterById(int id)
		{
			var character = DbContext.Characters.Where(c => c.Id== id).FirstOrDefault();

			return character;
		}

	}

	public interface ICharacteryRepository : IRepository<Character>
	{
		Character GetCharacterById(int id);
	}
}
