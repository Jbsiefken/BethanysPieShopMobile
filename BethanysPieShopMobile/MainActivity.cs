using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace BethanysPieShopMobile
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            //Views must be identified by their id in Resource.designer.cs
            //this is because views and activities aren't formally associated until runtime
            Button myButton = FindViewById<Button>(Resource.Id.MyButton);
            //on click of myButton, call method MyButton_Click
            myButton.Click += MyButton_Click;
        }

        private void MyButton_Click(object sender, System.EventArgs e)
        {
            //a static Toast method for displaying a message
            var toast = Toast.MakeText(this, "A button was clicked", ToastLength.Short);
            toast.Show();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}