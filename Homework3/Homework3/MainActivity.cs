using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Views;
using System;
using Android.Content;
using Android.Support.Design.Widget;


namespace Homework3
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        Button btnShow;
        Button btnShow2;
        Button btnShow3;
        Button btnShow4;
        TextView text1;
        TextView text2;
        TextView text3;
        TextView text4;
        


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource

            SetContentView(Resource.Layout.activity_main);


            btnShow = FindViewById<Button>(Resource.Id.ok);
            btnShow.Click += BtnShow_Click;

            btnShow2 = FindViewById<Button>(Resource.Id.ok2);
            btnShow2.Click += BtnShow_Click2;

            btnShow3 = FindViewById<Button>(Resource.Id.ok3);
            btnShow3.Click += BtnShow_Click3;

            btnShow4 = FindViewById<Button>(Resource.Id.ok4);
            btnShow4.Click += BtnShow_Click4;

        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            PopupMenu menu = new PopupMenu(this, btnShow);
            menu.MenuInflater.Inflate(Resource.Menu.popupmenu, menu.Menu);

            text1 = FindViewById<TextView>(Resource.Id.label);
            string new_text1 = text1.Text.Substring(text1.Text.LastIndexOf(':')+2);

            menu.MenuItemClick += (s, arg) =>
            {

                //buraya menüdeki itemlere tıkladıktan sonra yapılacak şeyleri yaz
                //burdaki veriyi alıp başka bir activity de o veriyi kullan
                //yeni sayfa açılsın
                var bundle = new Bundle();
                bundle.PutString("Subject", (arg.Item.TitleFormatted).ToString());
                bundle.PutString("Email", new_text1);

                Intent myintent = new Intent(this, typeof(Activity2));
                myintent.PutExtras(bundle);
                StartActivity(myintent);        
            };

            menu.DismissEvent += (s, arg) =>
            {
                Toast.MakeText(this, string.Format("Menu dismissed"), ToastLength.Short).Show();

            };

            menu.Show();
        }


        private void BtnShow_Click2(object sender, EventArgs e)
        {
            PopupMenu menu = new PopupMenu(this, btnShow2);
            menu.MenuInflater.Inflate(Resource.Menu.popupmenu, menu.Menu);

            text2 = FindViewById<TextView>(Resource.Id.label2);
            string new_text2 = text2.Text.Substring(text2.Text.LastIndexOf(':')+2);

            menu.MenuItemClick += (s, arg) =>
            {
                
                var bundle = new Bundle();
                bundle.PutString("Subject", (arg.Item.TitleFormatted).ToString());
                bundle.PutString("Email", new_text2);

                Intent myintent = new Intent(this, typeof(Activity2));
                myintent.PutExtras(bundle);
                StartActivity(myintent);
            };

            menu.DismissEvent += (s, arg) =>
            {
                Toast.MakeText(this, string.Format("Menu dismissed"), ToastLength.Short).Show();

            };

            menu.Show();
        }

        private void BtnShow_Click3(object sender, EventArgs e)
        {
            PopupMenu menu = new PopupMenu(this, btnShow3);
            menu.MenuInflater.Inflate(Resource.Menu.popupmenu, menu.Menu);

            text3 = FindViewById<TextView>(Resource.Id.label3);
            string new_text3 = text3.Text.Substring(text3.Text.LastIndexOf(':')+2);

            menu.MenuItemClick += (s, arg) =>
            {

                var bundle = new Bundle();
                bundle.PutString("Subject", (arg.Item.TitleFormatted).ToString());
                bundle.PutString("Email", new_text3);

                Intent myintent = new Intent(this, typeof(Activity2));
                myintent.PutExtras(bundle);
                StartActivity(myintent);
            };

            menu.DismissEvent += (s, arg) =>
            {
                Toast.MakeText(this, string.Format("Menu dismissed"), ToastLength.Short).Show();

            };

            menu.Show();
        }

        private void BtnShow_Click4(object sender, EventArgs e)
        {
            PopupMenu menu = new PopupMenu(this, btnShow4);
            menu.MenuInflater.Inflate(Resource.Menu.popupmenu, menu.Menu);

            text4 = FindViewById<TextView>(Resource.Id.label4);
            string new_text4 = text4.Text.Substring(text4.Text.LastIndexOf(':')+2);

            menu.MenuItemClick += (s, arg) =>
            {

                var bundle = new Bundle();
                bundle.PutString("Subject", (arg.Item.TitleFormatted).ToString());
                bundle.PutString("Email", new_text4);

                Intent myintent = new Intent(this, typeof(Activity2));
                myintent.PutExtras(bundle);
                StartActivity(myintent);
            };

            menu.DismissEvent += (s, arg) =>
            {
                Toast.MakeText(this, string.Format("Menu dismissed"), ToastLength.Short).Show();

            };

            menu.Show();
        }
    }
}