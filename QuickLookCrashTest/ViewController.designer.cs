// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace QuickLookCrashTest
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton btnOpenSample { get; set; }

		[Action ("btnOpenSamplePDF:")]
		partial void btnOpenSamplePDF (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (btnOpenSample != null) {
				btnOpenSample.Dispose ();
				btnOpenSample = null;
			}
		}
	}
}
