using MvvmCross.Core.ViewModels;
using UIKit;

namespace VoIpMvvmCross.iOS.Controls
{
    public interface IMvxSplitViewController
    {
        void ShowMasterView(UIViewController viewController, bool wrapInNavigationController);

        void ShowDetailView(UIViewController viewController, bool wrapInNavigationController);

        bool CloseChildViewModel(IMvxViewModel viewModel);
    }
}
