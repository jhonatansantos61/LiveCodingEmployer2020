using Live.Caqui.Consumption.Interface;
using Live.Caqui.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Live.Caqui.Consumption
{
    public class Satisfaction : ISatisfaction
    {

        private readonly ISyncAsync _iSyncAsync;
        public Satisfaction(ISyncAsync ISyncAsync)
        {
            _iSyncAsync = ISyncAsync;
        }
        public async Task<List<SatisfactionModel>> GetSatisfaction(string Hash)
        {
            var result = new List<SatisfactionModel>();
            _iSyncAsync.HTTPVerb = HTTPVerb.GET;
            _iSyncAsync.Url = "https://live.paulomaestro.com.br/Satisfation/GetSatisfaction" + "?GetSatisfaction=" + Hash;
            var resultAux = await _iSyncAsync.GoSyncAsync();

            if (!resultAux.Item1)
            {
                result = JsonConvert.DeserializeObject<List<SatisfactionModel>>(resultAux.Item2);
            }
            return result;
        }
        public async Task<List<SatisfactionModel>> PostSatisfaction(SatisfactionModel Satisfaction)
        {
            var result = new List<SatisfactionModel>();
            _iSyncAsync.HTTPVerb = HTTPVerb.POST;
            _iSyncAsync.Url = "https://live.paulomaestro.com.br/Satisfation/PostSatisfaction";
            _iSyncAsync.Obj = Satisfaction;
            var resultAux = await _iSyncAsync.GoSyncAsync();

            if (!resultAux.Item1)
            {
                result = JsonConvert.DeserializeObject<List<SatisfactionModel>>(resultAux.Item2);
            }
            return result;
        }
    }
}
