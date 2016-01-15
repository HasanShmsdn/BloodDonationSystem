using System;
using Core.Models;

namespace Api.Models.Mappers.Imp
{
    public class LoginMapper
    {
        public Users Map(LoginForm form)
        {
            var user = new Users();
            user.Id = 0;
            user.MembName = form.MembName;
            user.Password = form.Password;
            user.Lastlogin = DateTime.Now;
            return user;
        }
    }
}