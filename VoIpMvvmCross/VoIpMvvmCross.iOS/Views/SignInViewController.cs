using System;
using MvvmCross.Binding.BindingContext;
using UIKit;
using VoIpMvvmCross.Core.ViewModels;
using VoIpMvvmCross.iOS.Views;

namespace VoIpMvvmCross.iOS
{
    public partial class SignInViewController : BaseViewController<SignInViewModel>
    {
        UIButton _signInButton => SignInButton;
        UIView _viewContainer => ViewContainer;
        UITextField _loginTextFiled => LoginTextFiled;
        UITextField _passwordTextField => PasswordTextFiled;

        MvxFluentBindingDescriptionSet<SignInViewController, SignInViewModel> _bindingSet;

        public SignInViewController(IntPtr handle) : base (handle)
		{
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title = "Sign In";

            Bind();
        }

        void Bind()
        {
            UITapGestureRecognizer dismissTap = new UITapGestureRecognizer(DismissKeyboard);
            _viewContainer.AddGestureRecognizer(dismissTap);

            _bindingSet = this.CreateBindingSet<SignInViewController, SignInViewModel>();

           _bindingSet.Bind(_signInButton).To(vm => vm.SignInCommand);

           _bindingSet.Apply();
        }

        private void DismissKeyboard()
        {
            _loginTextFiled.ResignFirstResponder();
            _passwordTextField.ResignFirstResponder();
        }
    }
}