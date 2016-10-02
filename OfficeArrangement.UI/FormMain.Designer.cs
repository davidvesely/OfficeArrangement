namespace OfficeArrangement.Sandbox
{
    partial class FormMain
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseBrandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choosePaletteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.hermanMillerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wilkhahnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoverImage = new TransparentControl();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(757, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.chooseBrandToolStripMenuItem,
            this.choosePaletteToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.loadToolStripMenuItem.Text = "Load...";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // chooseBrandToolStripMenuItem
            // 
            this.chooseBrandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hermanMillerToolStripMenuItem,
            this.wilkhahnToolStripMenuItem});
            this.chooseBrandToolStripMenuItem.Name = "chooseBrandToolStripMenuItem";
            this.chooseBrandToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.chooseBrandToolStripMenuItem.Text = "Choose brand";
            // 
            // choosePaletteToolStripMenuItem
            // 
            this.choosePaletteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightToolStripMenuItem,
            this.darkToolStripMenuItem});
            this.choosePaletteToolStripMenuItem.Name = "choosePaletteToolStripMenuItem";
            this.choosePaletteToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.choosePaletteToolStripMenuItem.Text = "Choose palette";
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Location = new System.Drawing.Point(0, 27);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(715, 350);
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseClick);
            this.pictureBoxMain.MouseLeave += new System.EventHandler(this.pictureBoxMain_MouseLeave);
            this.pictureBoxMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseMove);
            // 
            // hermanMillerToolStripMenuItem
            // 
            this.hermanMillerToolStripMenuItem.Checked = true;
            this.hermanMillerToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hermanMillerToolStripMenuItem.Name = "hermanMillerToolStripMenuItem";
            this.hermanMillerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hermanMillerToolStripMenuItem.Text = "Herman Miller";
            this.hermanMillerToolStripMenuItem.Click += new System.EventHandler(this.hermanMillerToolStripMenuItem_Click);
            // 
            // wilkhahnToolStripMenuItem
            // 
            this.wilkhahnToolStripMenuItem.Name = "wilkhahnToolStripMenuItem";
            this.wilkhahnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.wilkhahnToolStripMenuItem.Text = "Wilkhahn";
            this.wilkhahnToolStripMenuItem.Click += new System.EventHandler(this.wilkhahnToolStripMenuItem_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Checked = true;
            this.lightToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // hoverImage
            // 
            this.hoverImage.BackColor = System.Drawing.Color.Transparent;
            this.hoverImage.Image = null;
            this.hoverImage.Location = new System.Drawing.Point(0, 27);
            this.hoverImage.Name = "hoverImage";
            this.hoverImage.Size = new System.Drawing.Size(42, 42);
            this.hoverImage.TabIndex = 2;
            this.hoverImage.Text = "transparentControl1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(757, 438);
            this.Controls.Add(this.hoverImage);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "Office Arrangement";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseBrandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choosePaletteToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private TransparentControl hoverImage;
        private System.Windows.Forms.ToolStripMenuItem hermanMillerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wilkhahnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
    }
}

