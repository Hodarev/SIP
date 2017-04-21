using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using VoIpMvvmCross.Core.ViewModels;

namespace VoIpMvvmCross.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<SignInViewModel>();
        }
    }
}
