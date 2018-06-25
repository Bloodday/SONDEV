using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ENTAJI.Droid.Effects;
using Java.Util;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(RoundCornerEffect), "PlaceholderEffect")]
namespace ENTAJI.Droid.Effects
{


    public class RoundCornerEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            Control.Background = Android.App.Application.Context.GetDrawable(Resource.Drawable.round_corners);
            Control.SetPadding(10, 0, 0, 0);
        }

        protected override void OnDetached()
        {
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
            // You can do effects only when certain properties change here.
        }
    }
}
