// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace VoIpMvvmCross.iOS
{
    [Register ("SignInViewController")]
    partial class SignInViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField LoginTextFiled { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField PasswordTextFiled { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SignInButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ViewContainer { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LoginTextFiled != null) {
                LoginTextFiled.Dispose ();
                LoginTextFiled = null;
            }

            if (PasswordTextFiled != null) {
                PasswordTextFiled.Dispose ();
                PasswordTextFiled = null;
            }

            if (SignInButton != null) {
                SignInButton.Dispose ();
                SignInButton = null;
            }

            if (ViewContainer != null) {
                ViewContainer.Dispose ();
                ViewContainer = null;
            }
        }
    }
}