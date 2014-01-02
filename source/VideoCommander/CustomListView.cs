using System;
using System.Security.Permissions;
using System.Windows.Forms;

namespace D16.VideoCommander
{
    internal class CustomListView : ListView
    {
        private const int WM_LBUTTONDBLCLK = 515;

        private bool doubleClickFired;

        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnDoubleClick(e);

            this.doubleClickFired = true;
        }

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        protected override void WndProc(ref Message m)
        {
            this.doubleClickFired = false;

            base.WndProc(ref m);

            if (m.Msg == WM_LBUTTONDBLCLK && !this.doubleClickFired)
            {
                this.OnDoubleClick(EventArgs.Empty);
            }
        }
    }
}
