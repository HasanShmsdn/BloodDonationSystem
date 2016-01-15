using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    // Models used as parameters to FeedsController actions.

    public class FeedsForm
    {
        public int UnitRequired { get; set; }
        public string UnitType { get; set; }
        public int UnitDonor { get; set; }
        public int HospId { get; set; }
    }

}
