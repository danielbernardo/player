namespace PlayIndoor
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cATEGORIAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cADASTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOBREAQIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNSERIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_playPrincipal = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cATEGORIAToolStripMenuItem1,
            this.sOBREAQIToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cATEGORIAToolStripMenuItem1
            // 
            this.cATEGORIAToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTARToolStripMenuItem,
            this.removerToolStripMenuItem});
            this.cATEGORIAToolStripMenuItem1.Name = "cATEGORIAToolStripMenuItem1";
            this.cATEGORIAToolStripMenuItem1.Size = new System.Drawing.Size(83, 20);
            this.cATEGORIAToolStripMenuItem1.Text = "CATEGORIA";
            // 
            // cADASTARToolStripMenuItem
            // 
            this.cADASTARToolStripMenuItem.Name = "cADASTARToolStripMenuItem";
            this.cADASTARToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cADASTARToolStripMenuItem.Text = "Cadastrar";
            this.cADASTARToolStripMenuItem.Click += new System.EventHandler(this.cADASTARToolStripMenuItem_Click);
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.removerToolStripMenuItem.Text = "Remover";
            this.removerToolStripMenuItem.Click += new System.EventHandler(this.removerToolStripMenuItem_Click);
            // 
            // sOBREAQIToolStripMenuItem
            // 
            this.sOBREAQIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNSERIRToolStripMenuItem});
            this.sOBREAQIToolStripMenuItem.Name = "sOBREAQIToolStripMenuItem";
            this.sOBREAQIToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sOBREAQIToolStripMenuItem.Text = "MÍDIAS";
            // 
            // iNSERIRToolStripMenuItem
            // 
            this.iNSERIRToolStripMenuItem.Name = "iNSERIRToolStripMenuItem";
            this.iNSERIRToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.iNSERIRToolStripMenuItem.Text = "Gerenciar";
            this.iNSERIRToolStripMenuItem.Click += new System.EventHandler(this.iNSERIRToolStripMenuItem_Click);
            // 
            // bt_playPrincipal
            // 
            this.bt_playPrincipal.AutoSize = true;
            this.bt_playPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.bt_playPrincipal.BackgroundImage = global::PlayIndoor.Properties.Resources.bt_play;
            this.bt_playPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_playPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_playPrincipal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_playPrincipal.FlatAppearance.BorderSize = 0;
            this.bt_playPrincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_playPrincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_playPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_playPrincipal.ForeColor = System.Drawing.Color.Transparent;
            this.bt_playPrincipal.Location = new System.Drawing.Point(548, 186);
            this.bt_playPrincipal.Name = "bt_playPrincipal";
            this.bt_playPrincipal.Size = new System.Drawing.Size(117, 107);
            this.bt_playPrincipal.TabIndex = 12;
            this.bt_playPrincipal.UseVisualStyleBackColor = true;
            this.bt_playPrincipal.Click += new System.EventHandler(this.bt_playPrincipal_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(787, 507);
            this.Controls.Add(this.bt_playPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(793, 531);
            this.MinimizeBox = false;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qi Player";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cATEGORIAToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cADASTARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOBREAQIToolStripMenuItem;
        private System.Windows.Forms.Button bt_playPrincipal;
        private System.Windows.Forms.ToolStripMenuItem iNSERIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
    }
}

