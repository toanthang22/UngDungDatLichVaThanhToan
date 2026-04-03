namespace ungdungdatlichvathanhtoantructuyen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            homeToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            btnresister = new Button();
            btnlogin = new Button();
            labellogo = new Label();
            panebanner = new Panel();
            panelsearch = new Panel();
            pictureBox1 = new PictureBox();
            panelcontent = new Panel();
            contextMenuStrip2.SuspendLayout();
            panel1.SuspendLayout();
            panebanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(117, 28);
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(116, 24);
            homeToolStripMenuItem.Text = "home";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(btnresister);
            panel1.Controls.Add(btnlogin);
            panel1.Controls.Add(labellogo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1139, 60);
            panel1.TabIndex = 5;
            // 
            // btnresister
            // 
            btnresister.Location = new Point(1033, 12);
            btnresister.Name = "btnresister";
            btnresister.Size = new Size(94, 29);
            btnresister.TabIndex = 2;
            btnresister.Text = "Đăng Ký";
            btnresister.UseVisualStyleBackColor = true;
            btnresister.Click += button1_Click;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(929, 12);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(94, 29);
            btnlogin.TabIndex = 1;
            btnlogin.Text = "Đăng Nhập";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // labellogo
            // 
            labellogo.AutoSize = true;
            labellogo.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labellogo.ForeColor = Color.White;
            labellogo.Location = new Point(12, 9);
            labellogo.Name = "labellogo";
            labellogo.Size = new Size(228, 34);
            labellogo.TabIndex = 0;
            labellogo.Text = "Ứng dụng đặt lịch";
            // 
            // panebanner
            // 
            panebanner.Controls.Add(panelsearch);
            panebanner.Controls.Add(pictureBox1);
            panebanner.Dock = DockStyle.Top;
            panebanner.Location = new Point(0, 60);
            panebanner.Name = "panebanner";
            panebanner.Size = new Size(1139, 250);
            panebanner.TabIndex = 6;
            panebanner.Paint += panebanner_Paint;
            // 
            // panelsearch
            // 
            panelsearch.BackColor = Color.White;
            panelsearch.BorderStyle = BorderStyle.FixedSingle;
            panelsearch.Location = new Point(93, 104);
            panelsearch.Name = "panelsearch";
            panelsearch.Size = new Size(401, 77);
            panelsearch.TabIndex = 1;
            panelsearch.Tag = "txtsearch";
            panelsearch.Paint += panelsearch_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.ErrorImage = Properties.Resources.anh_bien;
            pictureBox1.Image = Properties.Resources.anh_bien;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1139, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelcontent
            // 
            panelcontent.Dock = DockStyle.Fill;
            panelcontent.Location = new Point(0, 310);
            panelcontent.Name = "panelcontent";
            panelcontent.Size = new Size(1139, 140);
            panelcontent.TabIndex = 7;
            panelcontent.Paint += panelcontent_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 450);
            Controls.Add(panelcontent);
            Controls.Add(panebanner);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            contextMenuStrip2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panebanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem homeToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem1;
        private ToolStripMenuItem homeToolStripMenuItem2;
        private ToolStripMenuItem đẶTLỊCHToolStripMenuItem;
        private ToolStripMenuItem tRANGCÁNHÂNToolStripMenuItem;
        private ToolStripMenuItem tHÔNGTINToolStripMenuItem;
        private ToolStripMenuItem qUẢNLÝToolStripMenuItem;
        private ToolStripMenuItem kHÁCHHÀNGToolStripMenuItem;
        private ToolStripMenuItem dỊCHVỤToolStripMenuItem;
        private ToolStripMenuItem lỊCHHẸNToolStripMenuItem;
        private ToolStripMenuItem tRỢGIÚPToolStripMenuItem;
        private ToolStripMenuItem tHÔNGTINToolStripMenuItem1;
        private Label label1;
        private Panel panel1;
        private Panel panebanner;
        private Label labellogo;
        private Panel panelcontent;
        private Button btnlogin;
        private Button btnresister;
        private PictureBox pictureBox1;
        private Panel panelsearch;
    }
}
