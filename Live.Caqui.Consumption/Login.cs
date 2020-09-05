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
        private readonly ISyncAsync _iSyncAsync;
        public Login(ISyncAsync ISyncAsync)
        {
            _iSyncAsync = ISyncAsync;
        }
        public async Task<string> GetUser(UserModel User)
        {
            var result = "";
            _iSyncAsync.HTTPVerb = HTTPVerb.GET;
            _iSyncAsync.Url = "https://live.paulomaestro.com.br/Satisfation/GetUser" + "?User=" + User.Login + "&Password=" + User.Password;
            var resultAux = await _iSyncAsync.GoSyncAsync();

            if (!resultAux.Item1)
            {
                result = resultAux.Item2;
            }
            return result;
        }

        public async Task<bool> PostUser(UserModel User)
        {
            var result = false;
            _iSyncAsync.HTTPVerb = HTTPVerb.POST;
            _iSyncAsync.Url = "https://live.paulomaestro.com.br/Satisfation/PostUser";
            _iSyncAsync.Obj = User;
            var resultAux = await _iSyncAsync.GoSyncAsync();

            if (!resultAux.Item1)
            {
                result = bool.Parse(resultAux.Item2);
            }
            return result;
        }
    }
}
