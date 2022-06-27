using System;
using QuickLook;

namespace QuickLookCrashTest
{
    public class PreviewControllerDataSource : QLPreviewControllerDataSource
    {
        private QLPreviewItem _item;

        public PreviewControllerDataSource(QLPreviewItem item)
        {
            _item = item;
        }

        public override nint PreviewItemCount(QLPreviewController controller)
        {
            return 1;
        }

        public override IQLPreviewItem GetPreviewItem(QLPreviewController controller, nint index)
        {
            return _item;
        }
    }
}
