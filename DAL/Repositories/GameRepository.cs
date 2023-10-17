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
    public class GameRepository : IGameRepository
    {
        public async Task<GameModel> Create(GameModel model)
        {
            using (var db = new EntityDatabase())
            {
                var result = db.Users.Add(model);
                db.SaveChanges();

                return result.Entity;
            }
        }

        public async Task<bool> Delete(GameModel model)
        {
            using (var db = new EntityDatabase())
            {
                db.Users.Remove(model);

                return true;
            }
        }

        public async Task<GameModel> GetById(Guid id)
        {
            using (var db = new EntityDatabase())
            {
                return db.Users.First(a => a.Id == id);
            }
        }

        public async Task<IEnumerable<GameModel>> Select()
        {
            using (var db = new EntityDatabase())
            {
                return db.Users.ToList();
            }
        }

        public async Task<GameModel> Update(GameModel model)
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
