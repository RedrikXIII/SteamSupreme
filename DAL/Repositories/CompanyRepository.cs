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
    public class CompanyRepository : ICompanyRepository
    {
        public async Task<CompanyModel> Create(CompanyModel model)
        {
            using (var db = new EntityDatabase())
            {
                var result = db.Companies.Add(model);
                db.SaveChanges();

                return result.Entity;
            }
        }

        public async Task<bool> Delete(CompanyModel model)
        {
            using (var db = new EntityDatabase())
            {
                db.Companies.Remove(model);

                return true;
            }
        }

        public async Task<CompanyModel> GetById(Guid id)
        {
            using (var db = new EntityDatabase())
            {
                return db.Companies.First(a => a.Id == id);
            }
        }

        public async Task<IEnumerable<CompanyModel>> Select()
        {
            using (var db = new EntityDatabase())
            {
                return db.Companies.ToList();
            }
        }

        public async Task<CompanyModel> Update(CompanyModel model)
        {
            using (var db = new EntityDatabase())
            {
                var result = db.Companies.Update(model);
                db.SaveChanges();

                return result.Entity;
            }
        }
    }
}
