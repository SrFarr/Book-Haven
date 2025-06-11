using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class CustomPanel : Panel
{
    private int borderRadius = 20;
    private int borderSize = 1;
    private Color borderColor = Color.Black;
    private Color gradientColor1 = Color.White;
    private Color gradientColor2 = Color.White;
    private int shadowDepth = 5;
    private int shadowSpread = 3;
    private Color shadowColor = Color.FromArgb(100, 0, 0, 0);

    public int BorderRadius
    {
        get { return borderRadius; }
        set { borderRadius = value; Invalidate(); }
    }

    public int BorderSize
    {
        get { return borderSize; }
        set { borderSize = value; Invalidate(); }
    }

    public Color BorderColor
    {
        get { return borderColor; }
        set { borderColor = value; Invalidate(); }
    }

    public Color GradientColor1
    {
        get { return gradientColor1; }
        set { gradientColor1 = value; Invalidate(); }
    }

    public Color GradientColor2
    {
        get { return gradientColor2; }
        set { gradientColor2 = value; Invalidate(); }
    }

    public int ShadowDepth
    {
        get { return shadowDepth; }
        set { shadowDepth = value; Invalidate(); }
    }

    public int ShadowSpread
    {
        get { return shadowSpread; }
        set { shadowSpread = value; Invalidate(); }
    }

    public Color ShadowColor
    {
        get { return shadowColor; }
        set { shadowColor = value; Invalidate(); }
    }

    public CustomPanel()
    {
        this.DoubleBuffered = true;
        this.ResizeRedraw = true;
        this.BackColor = Color.Transparent;
        this.Padding = new Padding(shadowDepth + shadowSpread);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // Rectangle untuk shadow
        Rectangle shadowRect = new Rectangle(
            shadowDepth,
            shadowDepth,
            this.ClientRectangle.Width - shadowDepth - shadowSpread,
            this.ClientRectangle.Height - shadowDepth - shadowSpread);

        // Rectangle untuk panel utama
        Rectangle mainRect = new Rectangle(
            shadowSpread,
            shadowSpread,
            this.ClientRectangle.Width - shadowDepth - shadowSpread,
            this.ClientRectangle.Height - shadowDepth - shadowSpread);

        // Gambar shadow
        if (shadowDepth > 0)
        {
            DrawShadow(e.Graphics, shadowRect, borderRadius, shadowDepth, shadowColor);
        }

        // Gambar panel utama
        using (GraphicsPath path = GetRoundedRectPath(mainRect, borderRadius))
        {
            // Gradient background
            using (LinearGradientBrush brush = new LinearGradientBrush(mainRect, gradientColor1, gradientColor2, LinearGradientMode.Vertical))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Border
            if (borderSize > 0)
            {
                using (Pen pen = new Pen(borderColor, borderSize))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }

            // Set region untuk clipping
            this.Region = new Region(path);
        }
    }

    private void DrawShadow(Graphics g, Rectangle rect, int radius, int depth, Color shadowColor)
    {
        // Buat path untuk shadow
        using (GraphicsPath path = GetRoundedRectPath(rect, radius))
        {
            // Gambar multiple layer untuk efek blur
            for (int i = 1; i <= depth; i++)
            {
                int alpha = shadowColor.A / depth * i;
                Color color = Color.FromArgb(alpha, shadowColor);

                using (Pen pen = new Pen(color, i * 2))
                {
                    pen.LineJoin = LineJoin.Round;
                    g.DrawPath(pen, path);
                }
            }
        }
    }

    private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        int diameter = radius * 2;

        if (radius <= 0)
        {
            path.AddRectangle(rect);
            return path;
        }

        path.StartFigure();
        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
        path.CloseFigure();

        return path;
    }
}