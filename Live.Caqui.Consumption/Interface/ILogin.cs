using Live.Caqui.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Live.Caqui.Consumption.Interface
{
    public interface ILogin
    {
        Task<string> GetUser(UserModel User);
        Task<bool> PostUser(string Hash, UserModel User);
    }
}
