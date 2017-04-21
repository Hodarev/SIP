using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.iOS.Views;
using MvvmCross.Platform.Platform;
using UIKit;

namespace VoIpMvvmCross.iOS.Controls
{
    public static class UIViewControllerExtensionMethods
    {
        public static IMvxIosView GetIMvxIosView(this UIViewController viewController)
        {
            var mvxView = viewController as IMvxIosView;
            if (mvxView == null)
            {
                MvxTrace.Warning($"Could not get IMvxIosView from ViewController {viewController.GetType().Name}");
            }
            return mvxView;
        }
    }
}
