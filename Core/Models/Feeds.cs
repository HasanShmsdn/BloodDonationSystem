using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Feeds
    {
        [Key]
        public int Id { set; get; }
        public string UnitType { set; get; }
        public int UnitRequest { set; get; }
        public int UnitOffered { set; get; }
        public int UnitDonor { set; get; }
        public DateTime Date { set; get; }
        public int UserId { set; get; }
        public string HospName { set; get; }

    }
}
