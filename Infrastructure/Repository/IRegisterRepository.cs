using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Infrastructure.Repository
{
    public interface IRegisterRepository
    {
        void InsertRegister(Register register);
        Register[] SelectAllRegisters();
        void UpdateRegister(Register register);
        void DeleteRegister(int val);
        Register GetRegister(int id);
        Register[] SelectRegisters(int id, out int total);
    }
}
