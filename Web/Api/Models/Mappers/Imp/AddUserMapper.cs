using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Core.Models;

namespace Api.Models.Mappers.Imp
{
    public class AddUserMapper: IAddUserMapper
    {
        public Users Map(CreatUserForm form)
        {
            var user = new Users();
            user.HospLocation = form.HospLocation;
            user.HospName = form.HospName;
            user.IsAdmin = form.IsAdmin;
            user.MembPosition = form.MembPosition;
            user.Password = form.Password;
            user.MembName = form.MembName;
            user.Lastlogin = DateTime.Now;
            return user;

        }
        public Users Map(int userId, CreatUserForm form)
        {
            var user = new Users();
            user.Id = userId;
            user.HospLocation = form.HospLocation;
            user.HospName = form.HospName;
            user.IsAdmin = form.IsAdmin;
            user.MembPosition = form.MembPosition;
            user.Password = form.Password;
            user.MembName = form.MembName;
            user.Lastlogin = DateTime.Now;
            return user;
        }
    }
}