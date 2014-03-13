namespace IndoorOnlinePlay
{
    partial class IndoorOnlinePlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndoorOnlinePlay));
            this.qiplay = new AxWMPLib.AxWindowsMediaPlayer();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lb_hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qiplay)).BeginInit();
            this.SuspendLayout();
            // 
            // qiplay
            // 
            this.qiplay.AllowDrop = true;
            this.qiplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qiplay.Enabled = true;
            this.qiplay.Location = new System.Drawing.Point(0, 0);
            this.qiplay.Name = "qiplay";
            this.qiplay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("qiplay.OcxState")));
            this.qiplay.Size = new System.Drawing.Size(980, 455);
            this.qiplay.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork_1);
            // 
            // lb_hora
            // 
            this.lb_hora.AutoSize = true;
            this.lb_hora.Location = new System.Drawing.Point(12, 399);
            this.lb_hora.Name = "lb_hora";
            this.lb_hora.Size = new System.Drawing.Size(0, 13);
            this.lb_hora.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // IndoorOnlinePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_hora);
            this.Controls.Add(this.qiplay);
            this.Name = "IndoorOnlinePlay";
            this.Text = "IndoorOnlinePlay";
            this.Load += new System.EventHandler(this.IndoorOnlinePlay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qiplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer qiplay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lb_hora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

