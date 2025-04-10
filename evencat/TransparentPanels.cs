using System.Drawing;
using System.Windows.Forms;
using System;

public class SemiTransparentPanel : Panel
{
    private int _alpha = 150; // Valor inicial (rango 0-255)
    private Color _backColor = Color.Gray;

    public int Alpha
    {
        get { return _alpha; }
        set
        {
            _alpha = Math.Max(0, Math.Min(255, value));
            this.Invalidate();
        }
    }

    public new Color BackColor
    {
        get { return _backColor; }
        set
        {
            _backColor = value;
            this.Invalidate();
        }
    }

    public SemiTransparentPanel()
    {
        SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        SetStyle(ControlStyles.Opaque, true);
        SetStyle(ControlStyles.ResizeRedraw, true);
        SetStyle(ControlStyles.UserPaint, true);
        SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        base.BackColor = Color.Transparent;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        using (var brush = new SolidBrush(Color.FromArgb(_alpha, _backColor)))
        {
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }

        // Dibujar bordes para mejor visualización (opcional)
        using (var pen = new Pen(Color.FromArgb(_alpha / 2, Color.Black)))
        {
            e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
        }
    }

    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
            cp.ExStyle |= 0x20; // WS_EX_TRANSPARENT
            return cp;
        }
    }
}