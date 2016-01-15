using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Api.Models.Mappers
{
    public interface IFeddsMapper
    {
        Feeds Map(FeedsForm form);
        Feeds Map(int n, FeedsForm form, string s);
    }
}
