﻿using System;

namespace Live.Caqui.Model
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string HashUser { get; set; }
        public static string Hash { get; set; }
    }
}
