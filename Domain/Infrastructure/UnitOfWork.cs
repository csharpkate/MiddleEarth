using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Infrastructure;

namespace Domain.Infrastructure
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly IDbFactory dbFactory;
		private MiddleEarthContext dbContext;

		public UnitOfWork(IDbFactory dbFactory)
		{
			this.dbFactory = dbFactory;
		}

		public MiddleEarthContext DbContext
		{
			get { return dbContext ?? (dbContext = dbFactory.Init()); }
		}

		public void Commit()
		{
			DbContext.Commit();
		}

	}
}
