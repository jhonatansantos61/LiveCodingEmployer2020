using Live.Caqui.Consumption;
using Live.Caqui.Consumption.Interface;
using LiveCodingEmployer.View;
using LiveCodingEmployer.ViewModel;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LiveCodingEmployer
{
    public partial class App : PrismApplication
    {
        public App()
            : this(null)
        {

        }

        public App(IPlatformInitializer initializer)
            : this(initializer, true)
        {

        }

        public App(IPlatformInitializer platformInitializer, bool setFormsDependencyResolver) : base(platformInitializer, setFormsDependencyResolver)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

#if DEBUG
            HotReloader.Current.Run(this);
#endif
            await NavigationService.NavigateAsync("RegisterUser");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<RegisterUser, RegisterUserViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<VotingPage, VotingPageViewModel>();

            containerRegistry.GetContainer().RegisterType<ILogin, Login>();
            containerRegistry.GetContainer().RegisterType<ISatisfaction, Satisfaction>();

        }
    }
}
