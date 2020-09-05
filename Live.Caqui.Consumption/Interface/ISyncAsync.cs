using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Live.Caqui.Consumption.Interface
{
    public interface ISyncAsync
    {
        object Obj { get; set; }
        HTTPVerb HTTPVerb { get; set; }
        string Url { get; set; }
        Task<(bool, string)> GoSyncAsync();
    }
}
