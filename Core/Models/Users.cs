using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string MembName { get; set; }
        public string Password { get; set; }
        public DateTime Lastlogin { get; set; }
        public string MembPosition { get; set; }
        public string HospName { get; set; }
        public string HospLocation { get; set; }
        public bool IsAdmin { get; set; }
    }
}
