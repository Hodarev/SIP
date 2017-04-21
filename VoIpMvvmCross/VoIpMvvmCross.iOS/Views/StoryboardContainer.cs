using System;
using System.Collections.Generic;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.iOS.Views;
using UIKit;

namespace VoIpMvvmCross.iOS.Views
{
    public class StoryboardContainer : MvxIosViewsContainer
    {
        protected override IMvxIosView CreateViewOfType(Type viewType, MvxViewModelRequest request)
        {
            return (IMvxIosView)UIStoryboard.FromName("Main", null)
                .InstantiateViewController(viewType.Name);
        }
    }
}