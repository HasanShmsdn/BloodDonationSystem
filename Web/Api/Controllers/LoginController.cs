using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Api.Models;
using Api.Models.Mappers;
using Api.Models.Mappers.Imp;
using Infrastructure.Repository;
using Infrastructure.Repository.Imp;
using Core.Models;

namespace Api.Controllers
{
    public class LoginController : ApiController
    {
        private ILoginRepository _loginRepository;
        private LoginMapper _loginMapper;
        private IAddUserRepository _addUserRepository;
        private IAddUserMapper _addUserMapper;

        public LoginController()
        {
            _loginRepository = new LoginRepository();
            _loginMapper = new LoginMapper();
            _addUserRepository = new AddUserRepository();
            _addUserMapper = new AddUserMapper();
        }

        // GET: api/Login
        [HttpPost]
        public Users Verif([FromBody] LoginForm form)
        {
            var map = _loginMapper.Map(form);
            var user = _loginRepository.Verification(map);
            return user;
        }

        [HttpPost]
        public void RegisterUser([FromBody] CreatUserForm user)
        {
            var map = _addUserMapper.Map(user);
            _addUserRepository.InsertUser(map);
        }

        [HttpGet]
        public IHttpActionResult GetUser(int id)
        {
            var user = _addUserRepository.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPut]
        public void EditUser([FromUri] int id, [FromBody] CreatUserForm user)
        {

            var map = _addUserMapper.Map(id, user);

            _addUserRepository.UpdateUser(map);

        }

        public IEnumerable<Users> Getall()
        {
            var users = _addUserRepository.GetAll();
            return users;
        }

        public void DeleteUser([FromUri] int id)
        {
            _addUserRepository.DeleteUser(id);
        }
    }
}
