using Live.Caqui.Model;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingEmployer.ViewModel
{
    public class VotingPageViewModel : ViewModelBase
    {
        private int _index;
        public int Index
        {
            get { return _index; }
            set { SetProperty(ref _index, value); }
        }

        private List<VotingModel> _voteParamater;
        public List<VotingModel> VoteParameter
        {
            get { return _voteParamater; }
            set { SetProperty(ref _voteParamater, value); }
        }

        public VotingPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Task.Run(() => LoadingVote());
        }

        public DelegateCommand VoteCommand
        {
            get
            {
                return new DelegateCommand(async () =>
                {
                    await Vote();
                });
            }
        }

        public DelegateCommand UpdateVote 
        {
            get
            {
                return new DelegateCommand(async () =>
               {
                   await LoadingVote();

               });
            }        
        }

        public async Task Vote()
        {
            string Description = string.Empty;

            switch (Index)
            {
                case 0:
                    Description = "Muito Satisfeito";
                    break;
                case 1:
                    Description = "Satisfeito";
                    break;
                case 2:
                    Description = "Razoavelmente Satisfeito";
                    break;
                case 3:
                    Description = "Pouco Satisfeito";
                    break;
                case 4:
                    Description = "Insatisfeito";
                    break;
            }

            await LoadingVote();
        }

        public async Task LoadingVote()
        {
            VoteParameter = await GetVote();
        }

        public async Task<List<VotingModel>> GetVote()
        {
            List<VotingModel> ListVote = new List<VotingModel>();
            ListVote.Add(new VotingModel()
            {
                Description = "Muito Satisfeito",
                Count = 12
            });
            ListVote.Add(new VotingModel()
            {
                Description = "Satisfeito",
                Count = 12
            });
            ListVote.Add(new VotingModel()
            {
                Description = "Razoavelmente Satisfeito",
                Count = 12
            });
            ListVote.Add(new VotingModel()
            {
                Description = "Pouco Satisfeito",
                Count = 12
            });
            ListVote.Add(new VotingModel()
            {
                Description = "Insatisfeito",
                Count = 12
            });

            return ListVote;
        }
    }
}
