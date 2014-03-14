namespace PlayIndoor
{
    partial class rep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rep));
            this.axplayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // axplayer
            // 
            this.axplayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axplayer.Enabled = true;
            this.axplayer.Location = new System.Drawing.Point(0, 0);
            this.axplayer.Name = "axplayer";
            this.axplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axplayer.OcxState")));
            this.axplayer.Size = new System.Drawing.Size(665, 299);
            this.axplayer.TabIndex = 0;
            // 
            // rep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 299);
            this.Controls.Add(this.axplayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Qi Player - Solução para Media Indoor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.rep_FormClosed);
            this.Load += new System.EventHandler(this.rep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axplayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axplayer;
    }
}