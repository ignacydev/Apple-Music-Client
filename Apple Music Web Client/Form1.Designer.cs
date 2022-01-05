namespace Apple_Music_Web_Client
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.wvAppleMusic = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.pnlDrag = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wvAppleMusic)).BeginInit();
            this.pnlDrag.SuspendLayout();
            this.SuspendLayout();
            // 
            // wvAppleMusic
            // 
            this.wvAppleMusic.CreationProperties = null;
            this.wvAppleMusic.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wvAppleMusic.Location = new System.Drawing.Point(0, 37);
            this.wvAppleMusic.Name = "wvAppleMusic";
            this.wvAppleMusic.Size = new System.Drawing.Size(1160, 580);
            this.wvAppleMusic.TabIndex = 0;
            this.wvAppleMusic.ZoomFactor = 1D;
            this.wvAppleMusic.Click += new System.EventHandler(this.AppleMusicShow_Click);
            // 
            // pnlDrag
            // 
            this.pnlDrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pnlDrag.Controls.Add(this.btnClose);
            this.pnlDrag.Location = new System.Drawing.Point(0, 0);
            this.pnlDrag.Name = "pnlDrag";
            this.pnlDrag.Size = new System.Drawing.Size(1160, 39);
            this.pnlDrag.TabIndex = 1;
            this.pnlDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDrag_MouseDown);
            this.pnlDrag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDrag_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1113, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 39);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 615);
            this.Controls.Add(this.pnlDrag);
            this.Controls.Add(this.wvAppleMusic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.wvAppleMusic)).EndInit();
            this.pnlDrag.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 wvAppleMusic;
        private System.Windows.Forms.Panel pnlDrag;
        private System.Windows.Forms.Button btnClose;
    }
}

