using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCar.Data.Entities;
using AppCar.infrustrcture.Irepos;
using AppCar.Service.IService;

namespace AppCar.Service.Service
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository _repo;

        public NotificationService(INotificationRepository repo)
        {
            _repo = repo;
            
        }

        public Task Add(Notification notification)
        {
            return _repo.AddAsync(notification);
        }

        public Task<IEnumerable<Notification>> GetAllByUser(int userId)
        {
            throw new NotImplementedException();
        }

        public Notification GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void MarkAsRead(int notificationId)
        {
            _repo.MarkAsReadAsync(notificationId);
        }
    }
}
