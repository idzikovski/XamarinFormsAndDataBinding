using CoreAnimation;
using Foundation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinFormsDemo;
using XamarinFormsDemo.iOS;

[assembly: ExportRenderer(typeof(CustomLabel), typeof(CustomLabelRenderer))]
namespace XamarinFormsDemo.iOS
{
    public class CustomLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            Device.BeginInvokeOnMainThread(() =>
            {
                CAShapeLayer layer = new CAShapeLayer();
                layer.StrokeColor = Color.Black.ToCGColor();
                layer.FillColor = null;
                NSNumber[] nSNumbers = { 4, 4 };
                layer.LineDashPattern = nSNumbers;
                layer.Path = UIBezierPath.FromRoundedRect(Layer.Bounds, 10).CGPath;
                layer.Frame = Layer.Bounds;
                Layer.AddSublayer(layer);
            });
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
        }
    }
}