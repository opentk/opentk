using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using OpenTK;
using OpenTK.Graphics;

namespace Examples.Tutorial
{
    [Activity(MainLauncher = true)]
    public class MainActivity : OpenTK.Platform.Android.GameActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override void Main()
        {
            SimpleES11Window.Main();
        }
    }
}
