using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp1.Enums
{
    public enum UnlockUserResult
    {
        Succes = 0,
        UserNotFaund = 1,
        UserAlreadyUnlocked = 2,
        NoAdminRights = 3,
        UnknownError = 4
    }
}
