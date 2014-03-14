namespace OnlinePlayIndoor
{
    partial class Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.backwork = new System.ComponentModel.BackgroundWorker();
            this.TimerVerifica = new System.Windows.Forms.Timer(this.components);
            this.qiplay = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.qiplay)).BeginInit();
            this.SuspendLayout();
            // 
            // backwork
            // 
            this.backwork.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backwork_DoWork);
            // 
            // TimerVerifica
            // 
            this.TimerVerifica.Enabled = true;
            this.TimerVerifica.Interval = 30000;
            this.TimerVerifica.Tick += new System.EventHandler(this.TimerVerifica_Tick);
            // 
            // qiplay
            // 
            this.qiplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qiplay.Enabled = true;
            this.qiplay.Location = new System.Drawing.Point(0, 0);
            this.qiplay.Name = "qiplay";
            this.qiplay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("qiplay.OcxState")));
            this.qiplay.Size = new System.Drawing.Size(886, 429);
            this.qiplay.TabIndex = 0;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 429);
            this.Controls.Add(this.qiplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solução Para Media Indoor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QiPlayer_FormClosed);
            this.Load += new System.EventHandler(this.QiPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qiplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backwork;
        private System.Windows.Forms.Timer TimerVerifica;
        private AxWMPLib.AxWindowsMediaPlayer qiplay;
    }
}

