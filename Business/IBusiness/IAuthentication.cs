using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IBusiness
{
    public interface IAuthentication
    {
        Task<bool> AuthenticateAsync();
    }
}
