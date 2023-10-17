using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public AccountModel Account { get; set; }
        public SettingsModel Settings { get; set; }
        public List<OrderModel> GameOrders { get; set; }
        public decimal Money { get; set; }
    }
}
