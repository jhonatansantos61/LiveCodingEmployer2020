using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveCodingEmployer.ViewModel
{
    public class RegisterUserViewModel : ViewModelBase
    {
        public RegisterUserViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
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
