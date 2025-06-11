using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class CustomTextBox : TextBox
{
    private int borderRadius = 10;
    private Color borderColor = Color.Gray;
    private int borderThickness = 1;

    public int BorderRadius
    {
        get => borderRadius;
        set { borderRadius = value; UpdateRegion(); Invalidate(); }
    }

    public Color BorderColor
    {
        get => borderColor;
        set { borderColor = value; Invalidate(); }
    }

    public int BorderThickness
    {
        get => borderThickness;
        set { borderThickness = value; Invalidate(); }
    }

    public CustomTextBox()
    {
        BorderStyle = BorderStyle.None;
        this.Padding = new Padding(5);
        this.BackColor = Color.White;
        this.ForeColor = Color.Black;

        this.Resize += (s, e) => UpdateRegion();
    }

    private void UpdateRegion()
    {
        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(Width - borderRadius, Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        using (Graphics g = this.CreateGraphics())
        using (Pen pen = new Pen(borderColor, borderThickness))
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            using (GraphicsPath path = GetRoundedRectPath(rect, borderRadius))
            {
                g.DrawPath(pen, path);
            }
        }
    }

    private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        float r = radius;
        path.AddArc(rect.X, rect.Y, r, r, 180, 90);
        path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
        path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
        path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
        path.CloseFigure();
        return path;
    }
}
