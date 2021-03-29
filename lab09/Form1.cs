using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace lab09
{
    public partial class Form1 : Form
    {
        private int x = 0, y = -47; //начальные координаты фигуры
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.KeyPreview = true;
            this.Text = "Lab 9. Momot Roman";

            panel1.Paint += new PaintEventHandler(panel1Paint);
        }
        private void panel1Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            DrawAxis(g);
            ApplyTransformation(g);
        }
        private void ApplyTransformation(Graphics g)
        {
            Matrix m = new Matrix();                            // Новая матрица преобразования
            m.Translate(panel1.Width / 2, panel1.Height / 2);   // Определяем центр

            // Перемещение 
            int dx = Convert.ToInt16(tbTranslationX.Text);
            int dy = -Convert.ToInt16(tbTranslationY.Text);
            m.Translate(dx, dy);

            // Маштабирование
            float sx = Convert.ToSingle(tbScaleX.Text);
            m.Scale(sx, sx);

            // Поворот
            float angle = Convert.ToSingle(tbRotaionAngle.Text);
            m.RotateAt(angle, new PointF(0, 0));

            // Сдвиг
            float alpha = Convert.ToSingle(tbShearX.Text);
            float beta = Convert.ToSingle(tbShearY.Text);
            m.Shear(alpha, beta);

            g.Transform = m;
            DrawFigure(g, Color.Black);
        }
        private void DrawFigure(Graphics g, Color color)
        {
            SolidBrush brush = new SolidBrush(color);
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

            g.FillPolygon(brush, curvePoints);
        }
        private void DrawAxis(Graphics g)
        {
            Matrix m = new Matrix();
            
            // определяем матрицу преобразований
            m.Translate(panel1.Width / 2, panel1.Height / 2);
            
            // Применяем матрицу преобразования к графическому объекту:
            g.Transform = m;
            
            // Рисуем оси x и y:
            g.DrawLine(Pens.Blue, -panel1.Width / 2, 0,panel1.Width / 2, 0);
            g.DrawLine(Pens.Blue, 0, -panel1.Height / 2,0, panel1.Height / 2);
            
            // Добавляем метки к осям X и Y:
            g.DrawString("X", this.Font, Brushes.Blue, panel1.Width / 2 - 20, -20);
            g.DrawString("Y", this.Font, Brushes.Blue, 5, -panel1.Height / 2 + 5);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Сбрасываем параметры к исходным
            tbTranslationX.Text = "0";
            tbTranslationY.Text = "0";
            tbScaleX.Text = "1";
            tbRotaionAngle.Text = "0";
            tbShearX.Text = "0";
            tbShearY.Text = "0";

            panelbm.Invalidate();
            panel1.Invalidate();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            {
                button1.PerformClick();// имитируем нажатие button1
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Right)
            {
                Matrix m = new Matrix();
                m.Translate(panel1.Width / 2, panel1.Height / 2);

                int dx = Convert.ToInt16(tbTranslationX.Text) + 1;
                tbTranslationX.Text = dx.ToString();

                int dy = -Convert.ToInt16(tbTranslationY.Text);
                m.Translate(dx, dy);

                panel1.Invalidate();
            }
            if (e.KeyValue == (char)Keys.Left)
            {
                Matrix m = new Matrix();
                m.Translate(panel1.Width / 2, panel1.Height / 2);

                int dx = Convert.ToInt16(tbTranslationX.Text) - 1;
                tbTranslationX.Text = dx.ToString();

                int dy = -Convert.ToInt16(tbTranslationY.Text);

                m.Translate(dx, dy);
                panel1.Invalidate();
            }
            if (e.KeyValue == (char)Keys.Up)
            {
                Matrix m = new Matrix();
                m.Translate(panel1.Width / 2, panel1.Height / 2);

                int dx = Convert.ToInt16(tbTranslationX.Text);
                int dy = Convert.ToInt16(tbTranslationY.Text) + 1;
                tbTranslationY.Text = dy.ToString();

                m.Translate(dx, dy);
                panel1.Invalidate();
            }
            if (e.KeyValue == (char)Keys.Down)
            {
                Matrix m = new Matrix();
                m.Translate(panel1.Width / 2, panel1.Height / 2);

                int dx = Convert.ToInt16(tbTranslationX.Text);
                int dy = Convert.ToInt16(tbTranslationY.Text) - 1;
                tbTranslationY.Text = dy.ToString();

                m.Translate(dx, dy);
                panel1.Invalidate();
            }
            if (e.KeyValue == (char)Keys.Up && e.KeyValue == (char)Keys.Left)
            {
                Matrix m = new Matrix();
                m.Translate(panel1.Width / 2, panel1.Height / 2);

                int dx = Convert.ToInt16(tbTranslationX.Text) - 1;
                tbTranslationX.Text = dx.ToString();

                int dy = Convert.ToInt16(tbTranslationY.Text) + 1;
                tbTranslationY.Text = dy.ToString();

                m.Translate(dx, dy);
                panel1.Invalidate();
            }
            if (e.KeyValue == (char)Keys.Up && e.KeyValue == (char)Keys.Right)
            {
                Matrix m = new Matrix();
                m.Translate(panel1.Width / 2, panel1.Height / 2);

                int dx = Convert.ToInt16(tbTranslationX.Text) + 1;
                tbTranslationX.Text = dx.ToString();

                int dy = Convert.ToInt16(tbTranslationY.Text) + 1;
                tbTranslationY.Text = dy.ToString();

                m.Translate(dx, dy);
                panel1.Invalidate();
            }
            if (e.KeyValue == (char)Keys.Down && e.KeyValue == (char)Keys.Right)
            {
                Matrix m = new Matrix();
                m.Translate(panel1.Width / 2, panel1.Height / 2);

                int dx = Convert.ToInt16(tbTranslationX.Text) + 1;
                tbTranslationX.Text = dx.ToString();

                int dy = Convert.ToInt16(tbTranslationY.Text) - 1;
                tbTranslationY.Text = dy.ToString();

                m.Translate(dx, dy);
                panel1.Invalidate();
            }
            if (e.KeyValue == (char)Keys.Down && e.KeyValue == (char)Keys.Left)
            {
                Matrix m = new Matrix();
                m.Translate(panel1.Width / 2, panel1.Height / 2);

                int dx = Convert.ToInt16(tbTranslationX.Text) - 1;
                tbTranslationX.Text = dx.ToString();

                int dy = Convert.ToInt16(tbTranslationY.Text) - 1;
                tbTranslationY.Text = dy.ToString();

                m.Translate(dx, dy);
                panel1.Invalidate();
            }
            if (e.KeyValue == (char)Keys.Q)
            {
                Matrix m = new Matrix();
                m.Translate(panel1.Width / 2, panel1.Height / 2);

                float angle = Convert.ToSingle(tbRotaionAngle.Text) - 1;
                tbRotaionAngle.Text = angle.ToString();

                m.RotateAt(angle, new PointF(0, 0));
            }
            if (e.KeyValue == (char)Keys.E)
            {
                Matrix m = new Matrix();
                m.Translate(panel1.Width / 2, panel1.Height / 2);

                float angle = Convert.ToSingle(tbRotaionAngle.Text) + 1;
                tbRotaionAngle.Text = angle.ToString();

                m.RotateAt(angle, new PointF(0, 0));
            }
        }
        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            {
                button2.PerformClick();// имитируем нажатие button2
            }
        }
        private void тЫКToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Q, E - Наклон фигуры\nСтрелки - Перемещение фигуры";
            string title = "Помощь";
            MessageBox.Show(message, title);
        }

        private void label3_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void tbScaleX_TextChanged(object sender, EventArgs e) { }
    }
}
