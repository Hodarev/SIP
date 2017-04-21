using Foundation;
using System;
using MvvmCross.Platform.iOS.Views;
using UIKit;
using MvvmCross.Platform.Core;
using VoIpMvvmCross.Core.ViewModels;
using VoIpMvvmCross.iOS.Controls;

namespace VoIpMvvmCross.iOS
{
    public partial class HomeViewController : MvxSplitViewController<HomeViewModel>
    {
        public HomeViewController (IntPtr handle) : base (handle)
        {
        }
    }
}