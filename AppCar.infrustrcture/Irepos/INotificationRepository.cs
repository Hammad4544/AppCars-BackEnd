using AppCar.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.infrustrcture.Irepos
{
    public interface INotificationRepository
    {

        Notification GetById(int id);
        Task<IEnumerable<Notification>> GetAllByUserAsync(int userId);
        Task AddAsync(Notification notification);
        void MarkAsReadAsync(int notificationId);
    }
}
