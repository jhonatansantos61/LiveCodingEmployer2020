using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveCodingEmployer.ViewModel
{
    public class RegisterUserViewModel : ViewModelBase
    {
        public RegisterUserViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        public DelegateCommand GoLoginPage
        {
            get
            {
                return new DelegateCommand(async () =>
                {
                    await NavigationService.NavigateAsync("LoginPage");
                });
            }
        }
    }
}
