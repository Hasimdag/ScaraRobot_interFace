using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class CustomTextBox : TextBox
{
    private const int SB_HORZ = 0;
    private const int SB_VERT = 1;

    [DllImport("user32.dll")]
    private static extern int ShowScrollBar(IntPtr hWnd, int wBar, int bShow);

    public CustomTextBox()
    {
        this.Multiline = true;
    }

    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);
        HideScrollBars();
    }

    private void HideScrollBars()
    {
        // Kaydırma çubuklarını gizle
        ShowScrollBar(this.Handle, SB_HORZ, 0);
        ShowScrollBar(this.Handle, SB_VERT, 0);
    }
}
