namespace ProNatur_Biomarkt_GmbH
{
    partial class LoadingScreen
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingScreen));
            this.progressBarLoading = new System.Windows.Forms.ProgressBar();
            this.Loading = new System.Windows.Forms.Label();
            this.lblLoadingProgress = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoadingBarTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarLoading
            // 
            this.progressBarLoading.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressBarLoading.Location = new System.Drawing.Point(12, 440);
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.Size = new System.Drawing.Size(946, 47);
            this.progressBarLoading.TabIndex = 0;
            // 
            // Loading
            // 
            this.Loading.AutoSize = true;
            this.Loading.BackColor = System.Drawing.Color.White;
            this.Loading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Loading.Font = new System.Drawing.Font("AniMe Vision - MB_EN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loading.ForeColor = System.Drawing.Color.Black;
            this.Loading.Location = new System.Drawing.Point(12, 440);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(100, 21);
            this.Loading.TabIndex = 1;
            this.Loading.Text = "Loading";
            // 
            // lblLoadingProgress
            // 
            this.lblLoadingProgress.AutoSize = true;
            this.lblLoadingProgress.BackColor = System.Drawing.Color.White;
            this.lblLoadingProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLoadingProgress.Font = new System.Drawing.Font("AniMe Vision - MB_EN", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingProgress.ForeColor = System.Drawing.Color.Black;
            this.lblLoadingProgress.Location = new System.Drawing.Point(908, 440);
            this.lblLoadingProgress.Name = "lblLoadingProgress";
            this.lblLoadingProgress.Size = new System.Drawing.Size(31, 18);
            this.lblLoadingProgress.TabIndex = 2;
            this.lblLoadingProgress.Text = "0%";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(972, 504);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LoadingBarTimer
            // 
            this.LoadingBarTimer.Interval = 50;
            this.LoadingBarTimer.Tick += new System.EventHandler(this.LoadingBarTimer_Tick);
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 499);
            this.ControlBox = false;
            this.Controls.Add(this.lblLoadingProgress);
            this.Controls.Add(this.Loading);
            this.Controls.Add(this.progressBarLoading);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProNatur-Biomarkt GmbH";
            this.Load += new System.EventHandler(this.LoadingScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarLoading;
        private System.Windows.Forms.Label Loading;
        private System.Windows.Forms.Label lblLoadingProgress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer LoadingBarTimer;
    }
}

