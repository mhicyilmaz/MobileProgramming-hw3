using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Homework3
{
    [Activity(Label = "Send Mail", Theme ="@style/AppTheme")]
    public class Activity2 : AppCompatActivity

    {

        TextView textmail;
        TextView textsubject;



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity2_layout);

            string a = base.Intent.Extras.GetString("Subject", "Not Found");
            string b = "Subject:" + a;
            string c = base.Intent.Extras.GetString("Email", "Not Found");
            textsubject = FindViewById<TextView>(Resource.Id.editText2);
            textsubject.Text = b;
            textmail = FindViewById<TextView>(Resource.Id.editText);
            textmail.Text = c;



        }
    }
}