using Live.Caqui.Consumption.Interface;
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
            return await Task.Run(() =>  Convert.ToBase64String(MD5.Create().ComputeHash(Convert.FromBase64String(User.Login + User.Password))));
        }

        public async Task<bool> PostUser(string Hash, UserModel User)
        {
            return true;
        }
    }
}
