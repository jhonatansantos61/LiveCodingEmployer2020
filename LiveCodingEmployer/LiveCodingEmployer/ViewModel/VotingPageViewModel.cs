using LiveCodingEmployer.Model;
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

        private List<VoteModel> _voteParamater;
        public List<VoteModel> VoteParameter
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

            await NavigationService.NavigateAsync("VotingPage");
        }

        public async Task LoadingVote()
        {
            VoteParameter = await GetVote();
        }

        public async Task<List<VoteModel>> GetVote()
        {
            List<VoteModel> ListVote = new List<VoteModel>();
            ListVote.Add(new VoteModel()
            {
                DescriptionVote = "Muito Satisfeito",
                Count = 12
            });
            ListVote.Add(new VoteModel()
            {
                DescriptionVote = "Satisfeito",
                Count = 12
            });
            ListVote.Add(new VoteModel()
            {
                DescriptionVote = "Razoavelmente Satisfeito",
                Count = 12
            });
            ListVote.Add(new VoteModel()
            {
                DescriptionVote = "Pouco Satisfeito",
                Count = 12
            });
            ListVote.Add(new VoteModel()
            {
                DescriptionVote = "Insatisfeito",
                Count = 12
            });

            return ListVote;
        }
    }
}
