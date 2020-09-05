using Live.Caqui.Consumption.Interface;
using Live.Caqui.Model;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingEmployer.ViewModel
{
    public class LoginPageViewModel : ViewModelBase
    {
        private readonly ILogin _login;

        private string _loginParameter;
        public string LoginParameter
        {
            get { return _loginParameter; }
            set { SetProperty(ref _loginParameter, value); }
        }

        private string _passwordParameter;
        public string PasswordParameter 
        {
            get { return _passwordParameter; }
            set { SetProperty(ref _passwordParameter, value); }
        }

        public LoginPageViewModel(ILogin Login, INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            _login = Login;
        }

        public DelegateCommand LoginCommand
        {
            get
            {
                return new DelegateCommand(async () =>
                {
                    await LoginUser();
                });
            }
        }

        public async Task LoginUser()
        {
            UserModel userModel = new UserModel();

            userModel.Login = LoginParameter;
            userModel.Password = PasswordParameter;

            UserModel.Hash = await _login.GetUser(userModel);

            if (!string.IsNullOrEmpty(UserModel.Hash))
                await NavigationService.NavigateAsync("VotingPage");
            else
                await PageDialogService.DisplayAlertAsync("Erro", "Usuário e/ou senha incorretos.", "OK");
        }
    }
}
