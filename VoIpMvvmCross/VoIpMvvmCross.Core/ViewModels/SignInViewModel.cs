
using System.Diagnostics;
using MvvmCross.Core.ViewModels;

namespace VoIpMvvmCross.Core.ViewModels
{
    public class SignInViewModel : MvxViewModel
    {
        #region Commands

        IMvxCommand _signInCommand;
        public IMvxCommand SignInCommand =>
            _signInCommand ?? (_signInCommand = new MvxCommand(OnSignIn));

        #endregion

        #region Helpers

        void OnSignIn()
        {
            ShowViewModel<HomeViewModel>();
            Debug.WriteLine("SignInViewModel OnSignIn");
        }

        #endregion
    }
}
