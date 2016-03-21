using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Infrastructure
{
	public interface IDbFactory : IDisposable
	{
		MiddleEarthContext Init();
	}
}
