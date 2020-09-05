using Live.Caqui.Consumption.Interface;
using Live.Caqui.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Live.Caqui.Consumption
{
    public class Satisfaction : ISatisfaction
    {
        public async Task<List<SatisfactionModel>> GetSatisfaction(string Hash) 
        {
            return null;
        }
        public async Task<List<SatisfactionModel>> PostSatisfaction(string Hash, SatisfactionModel Satisfaction)
        {
            return null;
        }
    }
}
