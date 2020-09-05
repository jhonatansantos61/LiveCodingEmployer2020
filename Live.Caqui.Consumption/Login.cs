using Live.Caqui.Consumption.Interface;
using Live.Caqui.Model;
using Newtonsoft.Json;
using System;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Live.Caqui.Consumption
{
    public class Login : ILogin
    {
        private const string Uri = "https://live.paulomaestro.com.br";
        private const string UriGetUser = Uri + "/Satisfation/GetUser";
        private const string UriPostUser = Uri + "/Satisfation/PostUser";

        private readonly ISyncAsync _iSyncAsync;
        public Login(ISyncAsync ISyncAsync)
        {
            _iSyncAsync = ISyncAsync;
        }
        public async Task<string> GetUser(UserModel User)
        {
            var result = "";
            _iSyncAsync.HTTPVerb = HTTPVerb.GET;
            _iSyncAsync.Url = UriGetUser;
            var resultAux = await _iSyncAsync.GoSyncAsync();

            if (!resultAux.Item1)
            {
                result = resultAux.Item2;
            }
            else
            {
                result = "";
            }
            return result;
        }

        public async Task<bool> PostUser(UserModel User)
        {
            return true;
        }
    }
}
