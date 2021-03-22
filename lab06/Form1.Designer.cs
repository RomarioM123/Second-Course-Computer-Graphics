using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(781, 425);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1590, 863);
            this.MinimumSize = new System.Drawing.Size(370, 273);
            this.Name = "Form1";
            this.Text = "Lab 6. Momot Roman";
            this.ResumeLayout(false);
        }

        #endregion
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            using (Pen selPen = new Pen(Color.Black))
            {
                SolidBrush brush = new SolidBrush(Color.Purple);

                Point[] curvePoints = {
                 new Point(210, 230),
                 new Point(210, 170),
                 new Point(300, 170),
                 new Point(350, 130),
                 new Point(420, 130),
                 new Point(470, 170),
                 new Point(560, 170),
                 new Point(560, 230)
                };
                e.Graphics.FillPolygon(brush, curvePoints);

                selPen.Width = 5;
                g.DrawLine(selPen, new Point(210, 230), new Point(210, 170));
                g.DrawLine(selPen, new Point(210, 170), new Point(300, 170));
                g.DrawLine(selPen, new Point(300, 170), new Point(350, 130));
                g.DrawLine(selPen, new Point(350, 130), new Point(422, 130));
                g.DrawLine(selPen, new Point(420, 130), new Point(470, 170));
                g.DrawLine(selPen, new Point(470, 170), new Point(560, 170));
                g.DrawLine(selPen, new Point(560, 170), new Point(560, 230));
                g.DrawLine(selPen, new Point(560, 230), new Point(520, 230));
                g.DrawLine(selPen, new Point(500, 170), new Point(500, 110));

                selPen.Color = Color.Red;
                Rectangle myRectangle = new Rectangle(490, 90, 20, 20);
                g.DrawEllipse(selPen, myRectangle);

                brush.Color = Color.Black;
                g.FillEllipse(brush, 230, 200, 65, 65);

                g.FillEllipse(brush, 450, 200, 65, 65);
            }
        }
    }
}