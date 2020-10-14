namespace VideoEdit
{
    partial class FormPrograma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrograma));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitarVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCambiarFormato = new System.Windows.Forms.Button();
            this.btnExtractAudio = new System.Windows.Forms.Button();
            this.btnRemoveAudio = new System.Windows.Forms.Button();
            this.wmpReproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnResolution = new System.Windows.Forms.Button();
            this.btnExtractFrames = new System.Windows.Forms.Button();
            this.lblVideoCargado = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpReproductor)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(161)))), ((int)(((byte)(160)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.sesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem,
            this.quitarVideoToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(161)))), ((int)(((byte)(160)))));
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.cargarToolStripMenuItem.Text = "Cargar...";
            this.cargarToolStripMenuItem.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
            // 
            // quitarVideoToolStripMenuItem
            // 
            this.quitarVideoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(161)))), ((int)(((byte)(160)))));
            this.quitarVideoToolStripMenuItem.Enabled = false;
            this.quitarVideoToolStripMenuItem.Name = "quitarVideoToolStripMenuItem";
            this.quitarVideoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.quitarVideoToolStripMenuItem.Text = "Quitar video";
            this.quitarVideoToolStripMenuItem.Click += new System.EventHandler(this.quitarVideoToolStripMenuItem_Click);
            // 
            // sesionToolStripMenuItem
            // 
            this.sesionToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sesionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.sesionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sesionToolStripMenuItem.Name = "sesionToolStripMenuItem";
            this.sesionToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sesionToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sesionToolStripMenuItem.Text = "Sesión";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(161)))), ((int)(((byte)(160)))));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.logoutToolStripMenuItem.Text = "Cerrar Sesión";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // btnCambiarFormato
            // 
            this.btnCambiarFormato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCambiarFormato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCambiarFormato.Enabled = false;
            this.btnCambiarFormato.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnCambiarFormato.FlatAppearance.BorderSize = 3;
            this.btnCambiarFormato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarFormato.ForeColor = System.Drawing.Color.White;
            this.btnCambiarFormato.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiarFormato.Image")));
            this.btnCambiarFormato.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCambiarFormato.Location = new System.Drawing.Point(12, 257);
            this.btnCambiarFormato.Name = "btnCambiarFormato";
            this.btnCambiarFormato.Size = new System.Drawing.Size(125, 63);
            this.btnCambiarFormato.TabIndex = 2;
            this.btnCambiarFormato.Text = "Cambiar Formato";
            this.btnCambiarFormato.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCambiarFormato.UseVisualStyleBackColor = true;
            this.btnCambiarFormato.Click += new System.EventHandler(this.btnCambiarFormato_Click);
            // 
            // btnExtractAudio
            // 
            this.btnExtractAudio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtractAudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExtractAudio.Enabled = false;
            this.btnExtractAudio.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnExtractAudio.FlatAppearance.BorderSize = 3;
            this.btnExtractAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtractAudio.ForeColor = System.Drawing.Color.White;
            this.btnExtractAudio.Image = ((System.Drawing.Image)(resources.GetObject("btnExtractAudio.Image")));
            this.btnExtractAudio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExtractAudio.Location = new System.Drawing.Point(12, 188);
            this.btnExtractAudio.Name = "btnExtractAudio";
            this.btnExtractAudio.Size = new System.Drawing.Size(125, 63);
            this.btnExtractAudio.TabIndex = 3;
            this.btnExtractAudio.Text = "Extraer Audio";
            this.btnExtractAudio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExtractAudio.UseVisualStyleBackColor = true;
            this.btnExtractAudio.Click += new System.EventHandler(this.btnExtractAudio_Click);
            // 
            // btnRemoveAudio
            // 
            this.btnRemoveAudio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveAudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemoveAudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemoveAudio.Enabled = false;
            this.btnRemoveAudio.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnRemoveAudio.FlatAppearance.BorderSize = 3;
            this.btnRemoveAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAudio.ForeColor = System.Drawing.Color.White;
            this.btnRemoveAudio.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveAudio.Image")));
            this.btnRemoveAudio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoveAudio.Location = new System.Drawing.Point(12, 119);
            this.btnRemoveAudio.Name = "btnRemoveAudio";
            this.btnRemoveAudio.Size = new System.Drawing.Size(125, 63);
            this.btnRemoveAudio.TabIndex = 4;
            this.btnRemoveAudio.Text = "Remover Audio";
            this.btnRemoveAudio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemoveAudio.UseVisualStyleBackColor = false;
            this.btnRemoveAudio.Click += new System.EventHandler(this.btnRemoveAudio_Click);
            // 
            // wmpReproductor
            // 
            this.wmpReproductor.Enabled = true;
            this.wmpReproductor.Location = new System.Drawing.Point(143, 73);
            this.wmpReproductor.Name = "wmpReproductor";
            this.wmpReproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpReproductor.OcxState")));
            this.wmpReproductor.Size = new System.Drawing.Size(517, 342);
            this.wmpReproductor.TabIndex = 7;
            // 
            // btnResolution
            // 
            this.btnResolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnResolution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnResolution.Enabled = false;
            this.btnResolution.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnResolution.FlatAppearance.BorderSize = 3;
            this.btnResolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResolution.ForeColor = System.Drawing.Color.White;
            this.btnResolution.Image = ((System.Drawing.Image)(resources.GetObject("btnResolution.Image")));
            this.btnResolution.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnResolution.Location = new System.Drawing.Point(666, 151);
            this.btnResolution.Name = "btnResolution";
            this.btnResolution.Size = new System.Drawing.Size(125, 63);
            this.btnResolution.TabIndex = 8;
            this.btnResolution.Text = "Cambiar Resolucion";
            this.btnResolution.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnResolution.UseVisualStyleBackColor = false;
            this.btnResolution.Click += new System.EventHandler(this.btnResolution_Click);
            // 
            // btnExtractFrames
            // 
            this.btnExtractFrames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtractFrames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExtractFrames.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExtractFrames.Enabled = false;
            this.btnExtractFrames.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnExtractFrames.FlatAppearance.BorderSize = 3;
            this.btnExtractFrames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtractFrames.ForeColor = System.Drawing.Color.White;
            this.btnExtractFrames.Image = ((System.Drawing.Image)(resources.GetObject("btnExtractFrames.Image")));
            this.btnExtractFrames.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExtractFrames.Location = new System.Drawing.Point(666, 225);
            this.btnExtractFrames.Name = "btnExtractFrames";
            this.btnExtractFrames.Size = new System.Drawing.Size(125, 63);
            this.btnExtractFrames.TabIndex = 9;
            this.btnExtractFrames.Text = "Extraer Imagenes";
            this.btnExtractFrames.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExtractFrames.UseVisualStyleBackColor = false;
            this.btnExtractFrames.Click += new System.EventHandler(this.btnExtractFrames_Click);
            // 
            // lblVideoCargado
            // 
            this.lblVideoCargado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVideoCargado.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblVideoCargado.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideoCargado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(187)))), ((int)(((byte)(174)))));
            this.lblVideoCargado.Location = new System.Drawing.Point(0, 24);
            this.lblVideoCargado.Name = "lblVideoCargado";
            this.lblVideoCargado.Size = new System.Drawing.Size(803, 47);
            this.lblVideoCargado.TabIndex = 6;
            this.lblVideoCargado.Text = "No se encontraron videos cargados.";
            this.lblVideoCargado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(803, 454);
            this.Controls.Add(this.lblVideoCargado);
            this.Controls.Add(this.btnExtractFrames);
            this.Controls.Add(this.btnResolution);
            this.Controls.Add(this.wmpReproductor);
            this.Controls.Add(this.btnRemoveAudio);
            this.Controls.Add(this.btnExtractAudio);
            this.Controls.Add(this.btnCambiarFormato);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormPrograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de video";
            this.TransparencyKey = System.Drawing.Color.DeepPink;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpReproductor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.Button btnCambiarFormato;
        private System.Windows.Forms.Button btnExtractAudio;
        private System.Windows.Forms.Button btnRemoveAudio;
        private AxWMPLib.AxWindowsMediaPlayer wmpReproductor;
        private System.Windows.Forms.Button btnResolution;
        private System.Windows.Forms.Button btnExtractFrames;
        private System.Windows.Forms.ToolStripMenuItem quitarVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label lblVideoCargado;
    }
}

