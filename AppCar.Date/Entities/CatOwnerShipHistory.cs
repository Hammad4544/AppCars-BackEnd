using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace   AppCar.Data.Entities
{
    public class CarOwnershipHistory
    {
        [Key]
        public int HistoryId { get; set; }
        public int CarId { get; set; }
        public CAR Car { get; set; } = null!;

        //public int OldOwnerId { get; set; }
        //public User OldOwner { get; set; } = null!;

        //public int NewOwnerId { get; set; }
        //public User NewOwner { get; set; } = null!;

        public DateTime TransferDate { get; set; } = DateTime.UtcNow;
        public string TransactionRef { get; set; } = Guid.NewGuid().ToString();
    }

}
