using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testing_Authentication_Project.Models;

namespace Testing_Authentication_Project.Repository
{
    public interface IJWTManagerRepository
    {
        Tokens Authenticate(Users users);
    }
}
