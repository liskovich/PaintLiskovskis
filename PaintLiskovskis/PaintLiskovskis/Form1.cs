using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Media;
using System.Windows.Forms;

namespace PaintLiskovskis
{    
    public partial class Form1 : Form
    {
        Graphics g;        
        Bitmap bmp;
        Pen p;
        Tool t;

        int x = 0;
        int y = 0;
        int fx;
        int fy;

        bool isActive;

        public Form1()
        {
            InitializeComponent();

            LoadImage(new Bitmap(pictureBox1.Width, pictureBox1.Height));

            p = new Pen(Color.Black, 2.0f);
            p.StartCap = p.EndCap = LineCap.Round;

            DoubleBuffered = true;
            pictureBox1.Cursor = Cursors.Cross;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            
            LoadImage(new Bitmap(pictureBox1.Width, pictureBox1.Height));
        }        

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {                
                LoadImage(new Bitmap(Image.FromFile(openFileDialog1.FileName)));
            }
        }

        private void LoadImage(Bitmap bitmap) 
        {
            bmp = bitmap;            
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(pictureBox1.Image);
            g.SmoothingMode = SmoothingMode.AntiAlias;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(pictureBox1.Width, pictureBox1.Height, g);
            pictureBox1.DrawToBitmap(img, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));

            SystemSounds.Asterisk.Play();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        img.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
                        break;
                    case 2:
                        img.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                        break;
                    case 3:
                        img.Save(saveFileDialog1.FileName, ImageFormat.Png);
                        break;
                    default:
                        break;
                }
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();

            printDocument1.DefaultPageSettings.Margins.Left = 50;
            printDocument1.DefaultPageSettings.Margins.Top = 50;
            printDocument1.PrintPage += new PrintPageEventHandler(PrintImage);
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void PrintImage(object sender, PrintPageEventArgs e)
        {
            Graphics pg = e.Graphics;
            pg.DrawImage(bmp, e.MarginBounds.Left, e.MarginBounds.Top);
        }
               
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isActive = true;

            x = e.X; 
            fx = e.X;

            y = e.Y; 
            fy = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            fx = e.X;
            fy = e.Y;

            if (isActive) {
                pictureBox1.Invalidate();

                switch (t)
                {
                    case Tool.Pen:
                        g.DrawLine(p, new Point(x, y), e.Location);
                        x = e.X;
                        y = e.Y;
                        break;
                    case Tool.Eraser:
                        g.DrawLine(new Pen(pictureBox1.BackColor, 30.0f), new Point(x, y), e.Location);
                        x = e.X;
                        y = e.Y;
                        break;
                    default:
                        break;
                }
            }

            pictureBox1.Image = bmp;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (t)
            {
                case Tool.Line:
                    g.DrawLine(p, x, y, fx, fy);
                    break;
                case Tool.Rect:
                    g.DrawRectangle(p, RectangleDraw());
                    break;
                case Tool.Ellipse:
                    g.DrawEllipse(p, RectangleDraw());
                    break;
                default:
                    break;
            }

            isActive = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (isActive) {
                switch (t)
                {
                    case Tool.Line:
                        e.Graphics.DrawLine(p, x, y, fx, fy);
                        break;
                    case Tool.Rect:
                        e.Graphics.DrawRectangle(p, RectangleDraw());
                        break;
                    case Tool.Ellipse:
                        e.Graphics.DrawEllipse(p, RectangleDraw());
                        break;
                    default:
                        break;
                }
            }
        }

        private void pen_Click(object sender, EventArgs e)
        {
            t = Tool.Pen;
            pictureBox1.Cursor = Cursors.Cross;
            isActive = false;
        }

        private void line_Click(object sender, EventArgs e)
        {
            t = Tool.Line;
            pictureBox1.Cursor = Cursors.Cross;
            isActive = false;
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            t = Tool.Rect;
            pictureBox1.Cursor = Cursors.Cross;
            isActive = false;
        }

        private void ellipse_Click(object sender, EventArgs e)
        {
            t = Tool.Ellipse;
            pictureBox1.Cursor = Cursors.Cross;
            isActive = false;
        }

        private void eraser_Click(object sender, EventArgs e)
        {
            t = Tool.Eraser;
            pictureBox1.Cursor = new Cursor(Properties.Resources.cursor.GetHicon());
            isActive = false;
        }

        private void color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                p.Color = colorDialog1.Color;
            }
        }

        private Rectangle RectangleDraw()
        {
            return new Rectangle(
                Math.Min(x, fx),
                Math.Min(y, fy),
                Math.Abs(fx - x),
                Math.Abs(fy - y));
        }
    }
}
