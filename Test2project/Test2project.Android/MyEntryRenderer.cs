using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Test2project.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Test2project;
using Android.Graphics.Drawables;
using Android.Text;
using Android.Content.Res;
using Android.Support.V4.Content;


[assembly: ExportRenderer(typeof(Entry), typeof(MyEntryRenderer))]

namespace Test2project.Droid
{
    class MyEntryRenderer: EntryRenderer
    {
        
            public MyEntryRenderer(Context context) : base(context)
            {
            }

            protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
            {
                base.OnElementChanged(e);

                if (Control != null)
                {


                Control.Background = ContextCompat.GetDrawable(Context, Resource.Drawable.box);

            }
            }
        
    }
}