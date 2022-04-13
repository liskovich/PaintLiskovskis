
namespace PaintLiskovskis
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pen = new System.Windows.Forms.ToolStripButton();
            this.line = new System.Windows.Forms.ToolStripButton();
            this.rectangle = new System.Windows.Forms.ToolStripButton();
            this.ellipse = new System.Windows.Forms.ToolStripButton();
            this.eraser = new System.Windows.Forms.ToolStripButton();
            this.color = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.printToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1623, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pen,
            this.line,
            this.rectangle,
            this.ellipse,
            this.eraser,
            this.color});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1623, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Images |*.bmp;*.jpeg;*.png";
            this.openFileDialog1.Title = "Open image from your PC";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Bmp image |*.bmp|Jpeg image |*.jpeg|Png image |*.png";
            this.saveFileDialog1.Title = "Save image to your PC";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(16, 64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1591, 821);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pen
            // 
            this.pen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pen.Image = global::PaintLiskovskis.Properties.Resources.pen;
            this.pen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pen.Name = "pen";
            this.pen.Size = new System.Drawing.Size(29, 24);
            this.pen.Text = "pen";
            this.pen.Click += new System.EventHandler(this.pen_Click);
            // 
            // line
            // 
            this.line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.line.Image = global::PaintLiskovskis.Properties.Resources.line;
            this.line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(29, 24);
            this.line.Text = "line";
            this.line.Click += new System.EventHandler(this.line_Click);
            // 
            // rectangle
            // 
            this.rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rectangle.Image = global::PaintLiskovskis.Properties.Resources.rect;
            this.rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(29, 24);
            this.rectangle.Text = "rectangle";
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // ellipse
            // 
            this.ellipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ellipse.Image = global::PaintLiskovskis.Properties.Resources.ellipse;
            this.ellipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ellipse.Name = "ellipse";
            this.ellipse.Size = new System.Drawing.Size(29, 24);
            this.ellipse.Text = "ellipse";
            this.ellipse.Click += new System.EventHandler(this.ellipse_Click);
            // 
            // eraser
            // 
            this.eraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eraser.Image = global::PaintLiskovskis.Properties.Resources.erase;
            this.eraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(29, 24);
            this.eraser.Text = "eraser";
            this.eraser.Click += new System.EventHandler(this.eraser_Click);
            // 
            // color
            // 
            this.color.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.color.Image = global::PaintLiskovskis.Properties.Resources.color;
            this.color.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(29, 24);
            this.color.Text = "colors";
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 900);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Paint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton pen;
        private System.Windows.Forms.ToolStripButton line;
        private System.Windows.Forms.ToolStripButton rectangle;
        private System.Windows.Forms.ToolStripButton ellipse;
        private System.Windows.Forms.ToolStripButton eraser;
        private System.Windows.Forms.ToolStripButton color;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

