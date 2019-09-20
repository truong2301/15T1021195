namespace SlideShow
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.Controls.Add(this.hScrollBar1);
            this.panel1.Controls.Add(this.pic3);
            this.panel1.Controls.Add(this.pic2);
            this.panel1.Controls.Add(this.pic5);
            this.panel1.Controls.Add(this.pic1);
            this.panel1.Controls.Add(this.pic4);
            this.panel1.Location = new System.Drawing.Point(83, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 144);
            this.panel1.TabIndex = 3;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.picMain);
            this.panelMain.Location = new System.Drawing.Point(253, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(157, 225);
            this.panelMain.TabIndex = 4;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar1.Location = new System.Drawing.Point(0, 127);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(501, 17);
            this.hScrollBar1.TabIndex = 3;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar1_Scroll);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.Image = global::SlideShow.Properties.Resources._out;
            this.pictureBox2.Location = new System.Drawing.Point(384, 291);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.Image = global::SlideShow.Properties.Resources._in;
            this.pictureBox1.Location = new System.Drawing.Point(253, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // picMain
            // 
            this.picMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMain.Image = global::SlideShow.Properties.Resources._1;
            this.picMain.Location = new System.Drawing.Point(0, 0);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(157, 225);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMain.TabIndex = 1;
            this.picMain.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic3.Location = new System.Drawing.Point(203, 5);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(95, 115);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3.TabIndex = 2;
            this.pic3.TabStop = false;
            this.pic3.Click += new System.EventHandler(this.Pic3_Click);
            this.pic3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pic3_MouseDown);
            this.pic3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pic3_MouseMove);
            this.pic3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pic3_MouseUp);
            // 
            // pic2
            // 
            this.pic2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic2.Location = new System.Drawing.Point(103, 25);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(75, 80);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 2;
            this.pic2.TabStop = false;
            this.pic2.Click += new System.EventHandler(this.Pic2_Click);
            // 
            // pic5
            // 
            this.pic5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic5.Location = new System.Drawing.Point(423, 25);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(75, 80);
            this.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic5.TabIndex = 2;
            this.pic5.TabStop = false;
            this.pic5.Click += new System.EventHandler(this.Pic5_Click);
            // 
            // pic1
            // 
            this.pic1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic1.Location = new System.Drawing.Point(3, 25);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(75, 80);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 2;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.Pic1_Click);
            // 
            // pic4
            // 
            this.pic4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic4.Location = new System.Drawing.Point(323, 25);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(75, 80);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic4.TabIndex = 2;
            this.pic4.TabStop = false;
            this.pic4.Click += new System.EventHandler(this.Pic4_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 507);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slide Show Image  _ 15T1021195 Tran Cong Truong (Auto SMY)";
            this.panel1.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

