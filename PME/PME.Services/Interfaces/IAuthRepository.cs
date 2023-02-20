using Microsoft.AspNetCore.Mvc;
using PME.Api.JwtTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PME.Services.Interfaces
{
    public interface IAuthRepository
    {
        Task<ActionResult<User>> Register(UserDto request);
        Task<ActionResult<string>> Login(UserDto request);
    }
}
