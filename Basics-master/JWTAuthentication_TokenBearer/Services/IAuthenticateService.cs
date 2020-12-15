using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTAuthentication_TokenBearer;

namespace JWTAuthentication_TokenBarer.Services
{
    public interface IAuthenticateService
    {
        Student Authenticate(String UserName, String Password);
    }
}
