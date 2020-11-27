using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinFormsDemo;
using XamarinFormsDemo.Droid;

[assembly: ExportRenderer(typeof(CustomLabel), typeof(CustomLabelRenderer))]
namespace XamarinFormsDemo.Droid
{
    public class CustomLabelRenderer : LabelRenderer
    {
        public CustomLabelRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            GradientDrawable drawable = new GradientDrawable();
            drawable.SetCornerRadius(10);
            drawable.SetStroke(5, Color.Black.ToAndroid(), 10, 10);
            Control.SetBackground(drawable);
        }
    }
}