namespace Animator_Demo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            AnimatorNS.Animation animation3 = new AnimatorNS.Animation();
            AnimatorNS.Animation animation4 = new AnimatorNS.Animation();
            this.header = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sidemenu = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.PicSettings = new System.Windows.Forms.PictureBox();
            this.PicHome = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelAnimator = new AnimatorNS.Animator(this.components);
            this.LogoAnimator = new AnimatorNS.Animator(this.components);
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.sidemenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.header.Controls.Add(this.button3);
            this.header.Controls.Add(this.pictureBox2);
            this.header.Controls.Add(this.label1);
            this.LogoAnimator.SetDecoration(this.header, AnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.header, AnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(894, 46);
            this.header.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PanelAnimator.SetDecoration(this.button3, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.button3, AnimatorNS.DecorationType.None);
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.button3.Location = new System.Drawing.Point(837, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 36);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PanelAnimator.SetDecoration(this.pictureBox2, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.pictureBox2, AnimatorNS.DecorationType.None);
            this.pictureBox2.Location = new System.Drawing.Point(6, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 35);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.PanelAnimator.SetDecoration(this.label1, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.label1, AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(53, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "(System Title)";
            // 
            // sidemenu
            // 
            this.sidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.sidemenu.Controls.Add(this.btnMenu);
            this.sidemenu.Controls.Add(this.PicSettings);
            this.sidemenu.Controls.Add(this.PicHome);
            this.sidemenu.Controls.Add(this.btnSettings);
            this.sidemenu.Controls.Add(this.logo);
            this.sidemenu.Controls.Add(this.btnHome);
            this.LogoAnimator.SetDecoration(this.sidemenu, AnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.sidemenu, AnimatorNS.DecorationType.None);
            this.sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenu.Location = new System.Drawing.Point(0, 46);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(282, 390);
            this.sidemenu.TabIndex = 2;
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.BackgroundImage")));
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnMenu, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnMenu, AnimatorNS.DecorationType.None);
            this.btnMenu.Location = new System.Drawing.Point(211, 18);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(46, 36);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            this.btnMenu.MouseLeave += new System.EventHandler(this.mouseHoverExitBtnMenu);
            this.btnMenu.MouseHover += new System.EventHandler(this.mouseHoverEnterBtnMenu);
            // 
            // PicSettings
            // 
            this.PicSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicSettings.BackgroundImage")));
            this.PicSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.PicSettings, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.PicSettings, AnimatorNS.DecorationType.None);
            this.PicSettings.Location = new System.Drawing.Point(3, 219);
            this.PicSettings.Name = "PicSettings";
            this.PicSettings.Size = new System.Drawing.Size(58, 44);
            this.PicSettings.TabIndex = 4;
            this.PicSettings.TabStop = false;
            this.PicSettings.WaitOnLoad = true;
            this.PicSettings.MouseLeave += new System.EventHandler(this.mouseHoverExitSettings);
            this.PicSettings.MouseHover += new System.EventHandler(this.mouseHoverEnterSettings);
            // 
            // PicHome
            // 
            this.PicHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicHome.BackgroundImage")));
            this.PicHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.PicHome, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.PicHome, AnimatorNS.DecorationType.None);
            this.PicHome.Location = new System.Drawing.Point(3, 156);
            this.PicHome.Name = "PicHome";
            this.PicHome.Size = new System.Drawing.Size(58, 44);
            this.PicHome.TabIndex = 0;
            this.PicHome.TabStop = false;
            this.PicHome.MouseLeave += new System.EventHandler(this.mouseHoverExitHome);
            this.PicHome.MouseHover += new System.EventHandler(this.mouseHoverEnterHome);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.PanelAnimator.SetDecoration(this.btnSettings, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnSettings, AnimatorNS.DecorationType.None);
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Silver;
            this.btnSettings.Location = new System.Drawing.Point(3, 214);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(277, 52);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "                    Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.MouseLeave += new System.EventHandler(this.mouseHoverExitSettings);
            this.btnSettings.MouseHover += new System.EventHandler(this.mouseHoverEnterSettings);
            // 
            // logo
            // 
            this.PanelAnimator.SetDecoration(this.logo, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.logo, AnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 18);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(181, 116);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.PanelAnimator.SetDecoration(this.btnHome, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnHome, AnimatorNS.DecorationType.None);
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Silver;
            this.btnHome.Location = new System.Drawing.Point(2, 151);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(277, 52);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "                    Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.MouseLeave += new System.EventHandler(this.mouseHoverExitHome);
            this.btnHome.MouseHover += new System.EventHandler(this.mouseHoverEnterHome);
            // 
            // panel1
            // 
            this.LogoAnimator.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(282, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 390);
            this.panel1.TabIndex = 4;
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = AnimatorNS.AnimationType.HorizSlide;
            this.PanelAnimator.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation3;
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = AnimatorNS.AnimationType.ScaleAndRotate;
            this.LogoAnimator.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(30);
            animation4.RotateCoeff = 0.5F;
            animation4.RotateLimit = 0.2F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.LogoAnimator.DefaultAnimation = animation4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(894, 436);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.header);
            this.PanelAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.sidemenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        //private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel sidemenu;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        //private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private AnimatorNS.Animator LogoAnimator;
        private AnimatorNS.Animator PanelAnimator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label btnSettings;
        private System.Windows.Forms.Label btnHome;
        private System.Windows.Forms.PictureBox PicSettings;
        private System.Windows.Forms.PictureBox PicHome;
        private System.Windows.Forms.PictureBox btnMenu;
    }
}

