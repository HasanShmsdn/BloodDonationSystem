﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Api.Models.Mappers
{
    interface ILoginMapper
    {
        Users Map(LoginForm form);
    }
}
