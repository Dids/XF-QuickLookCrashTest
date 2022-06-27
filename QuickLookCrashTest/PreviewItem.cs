using System;
using Foundation;
using QuickLook;

namespace QuickLookCrashTest
{
    public class PreviewItem : QLPreviewItem
    {
        string _filePath;

        public override NSUrl ItemUrl => NSUrl.FromFilename(_filePath);
        public override string ItemTitle => NSUrl.FromFilename(_filePath).LastPathComponent;

        public PreviewItem(string filePath)
        {
            _filePath = filePath;
        }
    }
}
