﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public interface IUserManager
    {
        string GetCurrentUserName();
        string[] GetUserNames();
    }
}
