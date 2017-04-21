using System;
using Cirrious.FluentLayouts.Touch;
using Foundation;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using UIKit;

namespace VoIpMvvmCross.iOS.Views
{
    public abstract class BaseViewController<TViewModel> : MvxViewController<TViewModel>
        where TViewModel : class, IMvxViewModel
    {
        public BaseViewController()
        {
        }
        public BaseViewController(string nibName, NSBundle bundle) : base(nibName, bundle)
        {
        }

        public BaseViewController(IntPtr handle) : base(handle)
        {
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            base.Title = Title;

            View.BackgroundColor = UIColor.White;

            // To customise your navigation bar correctly, refer to the documentation at https://developer.xamarin.com/recipes/ios/content_controls/navigation_controller
            NavigationController.NavigationBar.BarStyle = UIBarStyle.Black;
            NavigationController.NavigationBar.Translucent = false;
            NavigationController.NavigationBar.Hidden = false;
            NavigationController.NavigationBar.BarTintColor = UIColor.FromRGB(38, 50, 56);
            NavigationController.NavigationBar.TintColor = UIColor.White;

            NavigationController.SetNeedsStatusBarAppearanceUpdate();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
        }
    }
}
