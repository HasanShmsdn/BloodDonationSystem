using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Feeds
    {
        [Key]
        public int BloodRequestId { set; get; }
        public string UnitType { set; get; }
        public int UnitRequest { set; get; }
        public int UnitOffered { set; get; }
        public int UnitDonor { set; get; }
        public DateTime Date { set; get; }
        public int HospId { set; get; }
        public string HospName { set; get; }

    }
}
