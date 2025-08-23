using AppCar.Data.Entities;
using AppCar.infrustrcture.Irepos;
using AppCar.infrustructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.infrustrcture.Repos
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly ApplicationDBContext _db;

        public NotificationRepository(ApplicationDBContext dBContext) {

            _db = dBContext;
        }
        public async Task AddAsync(Notification notification)
        {
           await _db.Notifications.AddAsync(notification);
            
        }

        public Task<IEnumerable<Notification>> GetAllByUserAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public   Notification GetById(int id)
        {
            return  _db.Notifications.SingleOrDefault(n => n.NotificationId == id);
        }

        public void MarkAsReadAsync(int notificationId)
        {
            _db.Notifications.Where(n => n.NotificationId == notificationId).ToList().ForEach(n => n.IsRead = true);
        }
    }
}
