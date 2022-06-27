using Foundation;
using QuickLook;
using System;
using System.IO;
using UIKit;

namespace QuickLookCrashTest
{
    public partial class ViewController : UIViewController
    {
        public ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            // Perform any additional setup after loading the view, typically from a nib.

            btnOpenSample.TouchUpInside += delegate (object sender, EventArgs e)
            {
                try
                {
                    var bundlePath = NSBundle.MainBundle.BundlePath;
                    var samplePdfPath = Path.Combine(bundlePath, "sample.pdf");

                    if (!File.Exists(samplePdfPath))
                        throw new FileNotFoundException($"Could not find the sample PDF file at the specified path", samplePdfPath);

                    QLPreviewController previewController = new QLPreviewController();
                    QLPreviewItem previewItem = new PreviewItem(samplePdfPath);
                    previewController.DataSource = new PreviewControllerDataSource(previewItem);

                    //
                    // FIXME: This will crash on aarch64 Macs (confirmed on M1 and M1 Pro)
                    //        when running in an iOS Simulator, however runs fine on a real device
                    //
                    // More information on this here, and a confirmation from an Apple engineer:
                    // https://developer.apple.com/forums/thread/702933
                    //
                    PresentViewController(previewController, true, null);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to present the sample PDF in QuickLook Preview: {ex}");
                    throw;
                }
            };
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
