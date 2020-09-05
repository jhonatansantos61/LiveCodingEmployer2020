using Live.Caqui.Consumption.Interface;
using Live.Caqui.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Live.Caqui.Consumption
{
    public class Satisfaction : ISatisfaction
    {
        public async Task<List<SatisfactionModel>> GetSatisfaction(string Hash)
        {
            return new List<SatisfactionModel>() {
                new SatisfactionModel(){
                    Description = "Muito Satisfeito",
                    Count = 18
                },
                new SatisfactionModel(){
                    Description = "Satisfeito",
                    Count = 18
                },
                new SatisfactionModel(){
                    Description = "Razoavelmente Satisfeito",
                    Count = 18
                },
                new SatisfactionModel(){
                    Description = "Pouco Satisfeito",
                    Count = 18
                },
                new SatisfactionModel(){
                    Description = "Insatisfeito",
                    Count = 18
                }
            };
        }
        public async Task<List<SatisfactionModel>> PostSatisfaction(SatisfactionModel Satisfaction)
        {
            var result = new List<SatisfactionModel>() {
                new SatisfactionModel(){
                    Description = "Muito Satisfeito",
                    Count = 18
                },
                new SatisfactionModel(){
                    Description = "Satisfeito",
                    Count = 18
                },
                new SatisfactionModel(){
                    Description = "Razoavelmente Satisfeito",
                    Count = 18
                },
                new SatisfactionModel(){
                    Description = "Pouco Satisfeito",
                    Count = 18
                },
                new SatisfactionModel(){
                    Description = "Insatisfeito",
                    Count = 18
                }
            };

            result.Select(x =>
            {
                if (x.Description == Satisfaction.Description)
                {
                    x.Count++;
                }
                return x;
            }).ToList();

            return result;
        }
    }
}
