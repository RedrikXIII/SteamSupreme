using DAL.Data;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class SettingsRepository : ISettingsRepository
    {
        public async Task<SettingsModel> Create(SettingsModel model)
        {
            using (var db = new EntityDatabase())
            {
                var result = db.SettingsModel.Add(model);
                db.SaveChanges();

                return result.Entity;
            }
        }

        public async Task<bool> Delete(SettingsModel model)
        {
            using (var db = new EntityDatabase())
            {
                db.SettingsModel.Remove(model);

                return true;
            }
        }

        public async Task<SettingsModel> GetById(Guid id)
        {
            using (var db = new EntityDatabase())
            {
                return db.SettingsModel.First(a => a.Id == id);
            }
        }

        public async Task<IEnumerable<SettingsModel>> Select()
        {
            using (var db = new EntityDatabase())
            {
                return db.SettingsModel.ToList();
            }
        }

        public async Task<SettingsModel> Update(SettingsModel model)
        {
            using (var db = new EntityDatabase())
            {
                var result = db.SettingsModel.Update(model);
                db.SaveChanges();

                return result.Entity;
            }
        }
    }
}
