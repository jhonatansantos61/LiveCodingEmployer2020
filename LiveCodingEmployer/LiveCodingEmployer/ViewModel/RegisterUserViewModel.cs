﻿using Live.Caqui.Consumption.Interface;
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
    public class RegisterUserViewModel : ViewModelBase
    {
        private readonly ILogin _login;

        private string _nameParameter;
        public string NameParameter
        {
            get { return _nameParameter; }
            set { SetProperty(ref _nameParameter, value); }
        }

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

        public RegisterUserViewModel(ILogin login, INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            _login = login;
        }

        public DelegateCommand RegisterUserCommand
        {
            get
            {
                return new DelegateCommand(async () =>
                {
                    await RegisterUser();
                });
            }
        }

        public DelegateCommand BackPage
        {
            get
            {
                return new DelegateCommand(async () =>
                {
                    await NavigationService.GoBackAsync();
                });
            }
        }

        public async Task RegisterUser()
        {
            UserModel userModel = new UserModel();

            userModel.Name = NameParameter;
            userModel.Login = LoginParameter;
            userModel.Password = PasswordParameter;

            var resultPost = await _login.PostUser(userModel);

            if (resultPost)
                await NavigationService.NavigateAsync("LoginPage");
            else
                await PageDialogService.DisplayAlertAsync("Erro", "Erro ao registrar usuário", "OK");
        }
    }
}
