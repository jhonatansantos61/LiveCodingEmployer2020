using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveCodingEmployer.ViewModel
{
    public class LoginPageViewModel : ViewModelBase
    {
        public LoginPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        public DelegateCommand GoVotingPage
        {
            get
            {
                return new DelegateCommand(async () =>
                {
                    await NavigationService.NavigateAsync("VotingPage");
                });
            }
        }
    }
}
