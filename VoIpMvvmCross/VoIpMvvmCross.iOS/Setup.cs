using MvvmCross.iOS.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters;
using UIKit;
using VoIpMvvmCross.Core;
using VoIpMvvmCross.iOS.Views;

namespace VoIpMvvmCross.iOS
{
    public class Setup : MvxIosSetup
    {
        // This is a basic MVX Setup class. It can be replaced with an advanced Setup class available in the MVX Template pack
        public Setup(MvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter)
            : base(applicationDelegate, presenter)
        {
        }

        protected override IMvxIosViewsContainer CreateIosViewsContainer()
        {
            return new StoryboardContainer();
        }

        // CreateApp() is the only method for which an override is required in Setup, however there are many other methods that you will probably need or want to override
        // Learn more about using Setup to register custom bindings, platform services, and more at https://github.com/MvvmCross/MvvmCross/wiki/Customizing-using-App-and-Setup#setupcs
        protected override IMvxApplication CreateApp() => new App();
    }
}
