using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Register
    {
        [Key]

        public int ClientId { set; get; }
        public string ClientBloodType { set; get; }
        public string ClientPhoneNb { set; get; }
        public string ClientName { set; get; }
        public DateTime Date { set; get; }

    }
}
