using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Insert.IO;
using Insert.IO.Actions;
using Insert.IO.Views.Custom;

[assembly: UsesPermission(Android.Manifest.Permission.Internet)]

namespace InsertIOTest
{
	[Activity(Label = "InsertIOTest", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.Main);

			var button = FindViewById<Button>(Resource.Id.button);
			var layout = FindViewById<LinearLayout>(Resource.Id.layout);

			button.Click += delegate
			{
			};

			//var circular = new InsertCircularCloseButton(this);
			//var cmd = new InsertCommand(
			//	null,
			//	"source",
			//	"destination",
			//	InsertCommandAction.InsertCommandActionAny,
			//	InsertCommandEventType.InsertCommandEventTypeAny,
			//	InsertCommand.InsertCommandScope.InsertCommandScopeAny);
			//circular.SetActions(new[] { cmd });
			//layout.AddView(circular, new ViewGroup.LayoutParams(128, 128));
		}
	}

	[Application]
	public class SampleApp : Application
	{
		protected SampleApp(IntPtr javaReference, JniHandleOwnership transfer)
			: base(javaReference, transfer)
		{
		}

		public override void OnCreate()
		{
			base.OnCreate();

			Console.WriteLine("Calling InitSDK...");

			Insert.IO.Insert.InitSDK(
				this,
				"REPLACE WITH APP KEY",
				"REPLACE WITH COMPANY NAME",
				new Callbacks());

			Console.WriteLine("InitSDK returned.");
		}
	}

	public class Callbacks : Java.Lang.Object, IInsertPhasesCallbackInterface
	{
		public void OnInitComplete()
		{
			Console.WriteLine("Init complete.");
		}

		public void OnInitFailed()
		{
			Console.WriteLine("Init failed.");
		}

		public void OnInitStarted()
		{
			Console.WriteLine("Init started...");
		}
	}
}
