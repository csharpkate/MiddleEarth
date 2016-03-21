using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Infrastructure
{
	public class DbFactory : Disposable, IDbFactory
	{
		MiddleEarthContext dbContext;

		public MiddleEarthContext Init()
		{
			return dbContext ?? (dbContext = new MiddleEarthContext());
		}

		protected override void DisposeCore()
		{
			if (dbContext != null) 
				dbContext.Dispose();
		}
	}
}
