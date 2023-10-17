using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
	internal interface IEntityRepository<T>
	{
		Task<T> Create(T model);
		Task<bool> Delete(T model);
		Task<T> GetById(Guid id);
		Task<IEnumerable<T>> Select();
		Task<T> Update(T model);
	}
}
