using DAL.Data;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public async Task<OrderModel> Create(OrderModel model)
        {
            using (var db = new EntityDatabase())
            {
                var result = db.Orders.Add(model);
                db.SaveChanges();

                return result.Entity;
            }
        }

        public async Task<bool> Delete(OrderModel model)
        {
            using (var db = new EntityDatabase())
            {
                db.Orders.Remove(model);

                return true;
            }
        }

        public async Task<OrderModel> GetById(Guid id)
        {
            using (var db = new EntityDatabase())
            {
                return db.Orders.First(a => a.Id == id);
            }
        }

        public async Task<IEnumerable<OrderModel>> Select()
        {
            using (var db = new EntityDatabase())
            {
                return db.Orders.ToList();
            }
        }

        public async Task<OrderModel> Update(OrderModel model)
        {
            using (var db = new EntityDatabase())
            {
                var result = db.Orders.Update(model);
                db.SaveChanges();

                return result.Entity;
            }
        }
    }
}
