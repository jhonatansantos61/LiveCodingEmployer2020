using Live.Caqui.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Live.Caqui.Consumption.Interface
{
    public interface ISatisfaction
    {
        Task<List<SatisfactionModel>> GetSatisfaction(string Hash);
        Task<List<SatisfactionModel>> PostSatisfaction(string Hash, SatisfactionModel Satisfaction);
    }
}
