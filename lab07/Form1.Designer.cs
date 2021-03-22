using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;

public class Form1 : Form
{
    private int x = 68, y = 14;
    Thread t;
    public Form1()
    {
        BackColor = Color.White;

        this.BackColor = Color.Red;
        this.Size = new System.Drawing.Size(520, 520);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.Text = "Lab 6. Momot Roman";

        t = new Thread(new ThreadStart(Run));
        t.Start();
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics g = e.Graphics; 
        SolidBrush brush = new SolidBrush(Color.Yellow);

        Point[] curvePoints = {
            new Point(x, y),
            new Point(x + 12, y + 37),
            new Point(x + 52, y + 37),
            new Point(x + 21, y + 59),
            new Point(x + 32, y + 95),
            new Point(x + 0, y + 75),
            new Point(x - 32, y + 95),
            new Point(x - 21, y + 59),
            new Point(x - 51, y + 37),
            new Point(x - 11, y + 37)
        };
        e.Graphics.FillPolygon(brush, curvePoints);

        base.OnPaint(e);
    }
    public void Run()
    {
        int dx = 2, dy = 2;

        while (true)
        {
            for (int i = 0; i < 140; i++)
            {
                x += dx;
                y = x * x * x / (x * x + 125);
                Invalidate();
                Thread.Sleep(10);
            }
            dx = -dx;
            dy = -dy;
        }
    }
}