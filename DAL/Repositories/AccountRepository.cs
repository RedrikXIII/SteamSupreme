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
	public class AccountRepository : IAccountRepository
	{
        public async Task<AccountModel> Create(AccountModel model)
        {
            using (var db = new EntityDatabase())
            {
                var result = db.Accounts.Add(model);
                db.SaveChanges();

                return result.Entity;
            }
        }

        public async Task<bool> Delete(AccountModel model)
        {
            using (var db = new EntityDatabase())
            {
                db.Accounts.Remove(model);

                return true;
            }
        }

        public async Task<AccountModel> GetById(Guid id)
        {
            using (var db = new EntityDatabase())
            {
                return db.Accounts.First(a => a.Id == id);
            }
        }

        public async Task<IEnumerable<AccountModel>> Select()
        {
            using (var db = new EntityDatabase())
            {
                return db.Accounts.ToList();
            }
        }

        public async Task<AccountModel> Update(AccountModel model)
        {
            using (var db = new EntityDatabase())
            {
                var result = db.Accounts.Update(model);
                db.SaveChanges();

                return result.Entity;
            }
        }
    }
}
