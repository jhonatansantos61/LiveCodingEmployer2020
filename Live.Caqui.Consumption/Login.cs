﻿using Live.Caqui.Consumption.Interface;
using Live.Caqui.Model;
using System;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Live.Caqui.Consumption
{
    public class Login : ILogin
    {
        public async Task<string> GetUser(UserModel User)
        {
            return User.Login + User.Password;
        }

        public async Task<bool> PostUser(UserModel User)
        {
            return true;
        }
    }
}
