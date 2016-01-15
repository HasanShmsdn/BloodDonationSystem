using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Api.Models.Mappers
{
   public interface IAddUserMapper
   {
       Users Map(CreatUserForm form);
       Users Map(int userId, CreatUserForm form);
   }
}
