using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Microsoft.Xna.Framework;

namespace PogoDoodle_Mono_Android
{
    [Activity(Label = "StickManTAF", MainLauncher = true, Icon = "@drawable/icon")]
    public class Container : AndroidGameActivity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            StickManTAF.Game.Activity = this;
            var g = new StickManTAF.Game();
            SetContentView(g.Window);
            g.Run();
        }
    }
}

