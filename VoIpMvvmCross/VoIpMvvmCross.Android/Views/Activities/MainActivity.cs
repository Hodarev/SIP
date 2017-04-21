using Android.App;
using Android.OS;
using Android.Views;
using MvvmCross.Droid.Platform;
using VoIpMvvmCross.Core.ViewModels;

namespace VoIpMvvmCross.Android.Views
{
    [Activity(
        Theme = "@style/VoIpMvvmCross.Android",
        WindowSoftInputMode = SoftInput.AdjustPan | SoftInput.StateHidden)]
    public class MainActivity : BaseActivity<MainContainerViewModel>
    {
        protected override int ActivityLayoutId => Resource.Layout.layout_activity;
    }
}
