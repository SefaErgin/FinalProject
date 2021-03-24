using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(UsersKey user);
        void Add(UsersKey user);
        UsersKey GetByMail(string email);
    }
}
