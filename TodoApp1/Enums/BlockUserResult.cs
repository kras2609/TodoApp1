using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp1.Enums
{
    public enum BlockUserResult
    {
        Succes = 0,
        UserNotFaund = 1,
        UserAlreadyBlocked = 2,
        NoAdminRights = 3,
        UnknownError = 4
    }
}
