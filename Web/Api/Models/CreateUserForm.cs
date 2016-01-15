
using System;

namespace Api.Models
{
    // Models returned by AccountController actions.

    public class CreatUserForm
    {
        public int MembId { get; set; }
        public string MembName { get; set; }
        public string MembEmail { get; set; }
        public string MembPhone { get; set; }
        public string Password { get; set; }
        public string MembPosition { get; set; }
        public string HospName { get; set; }
        public string HospLocation { get; set; }
        public bool IsAdmin { get; set; }
    }
}
