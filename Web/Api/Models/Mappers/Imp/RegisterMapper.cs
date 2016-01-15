using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Core.Models;

namespace Api.Models.Mappers.Imp
{
    public class RegisterMapper
    {
        public Register Map(RegisterForm form)
        {
            var register = new Register();
            register.ClientName = form.ClientName;
            register.ClientBloodType = form.ClientBloodType;
            register.ClientPhoneNb = form.ClientPhoneNb;
            register.Date = form.Date;
            return register;
        }
        public Register Map(int n, RegisterForm form)
        {
            var register = new Register();
            register.ClientId = n;
            register.ClientName = form.ClientName;
            register.ClientBloodType = form.ClientBloodType;
            register.Date = DateTime.Now;
            return register;
        }
    }
}