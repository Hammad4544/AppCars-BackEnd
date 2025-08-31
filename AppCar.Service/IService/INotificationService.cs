using AppCar.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Service.IService
{
    public interface INotificationService
    {
        Notification GetById(int id);
        Task<IEnumerable<Notification>> GetAllByUser(int userId);
        Task Add(Notification notification);
        void MarkAsRead(int notificationId);
    }
}
