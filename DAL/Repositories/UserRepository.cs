using DAL.Data;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
	public class UserRepository : IUserRepository
	{
		public async Task<UserModel> Create(UserModel model)
		{
			using(var db = new EntityDatabase())
			{
				var result = db.Users.Add(model);
				db.SaveChanges();

				return result.Entity;
			}
		}

		public async Task<bool> Delete(UserModel model)
		{
			using (var db = new EntityDatabase())
			{
				db.Users.Remove(model);

				return true;
			}
		}

		public async Task<UserModel> GetById(Guid id)
		{
			using (var db = new EntityDatabase())
			{
				return db.Users.First(u => u.Id == id);
			}
		}

		public async Task<IEnumerable<UserModel>> Select()
		{
			using (var db = new EntityDatabase())
			{
				return db.Users.ToList();
			}
		}

		public async Task<UserModel> Update(UserModel model)
		{
			using (var db = new EntityDatabase())
			{
				var result = db.Users.Update(model);
				db.SaveChanges();

				return result.Entity;
			}
		}
	}
}
