using io.github.toyota32k.toolkit.utils;
using System;
using System.Windows;
using System.Windows.Input;

namespace io.github.toyota32k.toolkit.view {
    public class WaitCursor : IDisposable {
        private WeakReference<FrameworkElement> CursorOwner;

        public Cursor Cursor {
            get => CursorOwner?.GetValue()?.Cursor;
            set {
                var co = CursorOwner?.GetValue();
                if(null!=co) {
                    co.Cursor = value;
                }
            }
        }

        private Cursor OrgCursor;

        public WaitCursor(FrameworkElement cursorOwner, Cursor waitCursor=null) {
            CursorOwner = new WeakReference<FrameworkElement>(cursorOwner);
            OrgCursor = cursorOwner.Cursor;
            cursorOwner.Cursor = waitCursor ?? Cursors.Wait;
        }

        public void Dispose() {
            Cursor = OrgCursor;
        }

        public static WaitCursor Start(FrameworkElement cursorOwner, Cursor waitCursor=null) {
            return new WaitCursor(cursorOwner, waitCursor);
        }
    }
}
