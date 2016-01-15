using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Antlr.Runtime;

namespace Api.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class RegisterForm
    {
        public RegisterForm()
        {
            Date = DateTime.Now;
        }
        public string ClientName { get; set; }
        public string ClientBloodType { get; set; }
        public string ClientPhoneNb { get; set; }
        public int ClientId { get; set; }
        public string UuId { get; set; }
        public DateTime Date { get; set; }
    }
}