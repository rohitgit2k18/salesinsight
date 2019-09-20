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
using SalesInsight.CustomControls;
using SalesInsight.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ScrollViewWithNotBar), typeof(ScrollViewWithNotBarRenderer))]
namespace SalesInsight.Droid.Renderers
{
    
    public class ScrollViewWithNotBarRenderer : ScrollViewRenderer
    {
        public ScrollViewWithNotBarRenderer(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || this.Element == null)
                return;

            if (e.OldElement != null)
                e.OldElement.PropertyChanged -= OnElementPropertyChanged;

            e.NewElement.PropertyChanged += OnElementPropertyChanged;

        }

        protected void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.HorizontalScrollBarEnabled = false;
            this.VerticalScrollBarEnabled = false;

        }
    }
}