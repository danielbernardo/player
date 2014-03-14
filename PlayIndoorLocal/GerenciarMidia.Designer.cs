namespace PlayIndoor
{
    partial class GerenciarMidia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciarMidia));
            this.lb_nomeCategoria = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnn_rodape = new System.Windows.Forms.Panel();
            this.bt_inserir = new System.Windows.Forms.Button();
            this.bt_remover = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pnn_player = new System.Windows.Forms.Panel();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnn_rodape.SuspendLayout();
            this.pnn_player.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_nomeCategoria
            // 
            this.lb_nomeCategoria.AutoSize = true;
            this.lb_nomeCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lb_nomeCategoria.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nomeCategoria.ForeColor = System.Drawing.Color.White;
            this.lb_nomeCategoria.Location = new System.Drawing.Point(3, 17);
            this.lb_nomeCategoria.Name = "lb_nomeCategoria";
            this.lb_nomeCategoria.Size = new System.Drawing.Size(54, 13);
            this.lb_nomeCategoria.TabIndex = 0;
            this.lb_nomeCategoria.Text = "Categoria";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(116, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(317, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Pré - Visualização";
            // 
            // pnn_rodape
            // 
            this.pnn_rodape.BackColor = System.Drawing.Color.WhiteSmoke;
            //this.pnn_rodape.BackgroundImage = global::Qi_Media_Show.Properties.Resources.fundo2;
            this.pnn_rodape.Controls.Add(this.bt_inserir);
            this.pnn_rodape.Controls.Add(this.bt_remover);
            this.pnn_rodape.Location = new System.Drawing.Point(4, 360);
            this.pnn_rodape.Name = "pnn_rodape";
            this.pnn_rodape.Size = new System.Drawing.Size(583, 52);
            this.pnn_rodape.TabIndex = 18;
            // 
            // bt_inserir
            // 
            this.bt_inserir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_inserir.Location = new System.Drawing.Point(289, 14);
            this.bt_inserir.Name = "bt_inserir";
            this.bt_inserir.Size = new System.Drawing.Size(84, 29);
            this.bt_inserir.TabIndex = 5;
            this.bt_inserir.Text = "Inserir";
            this.bt_inserir.UseVisualStyleBackColor = true;
            this.bt_inserir.Click += new System.EventHandler(this.bt_inserir_Click);
            // 
            // bt_remover
            // 
            this.bt_remover.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_remover.Location = new System.Drawing.Point(379, 14);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(84, 30);
            this.bt_remover.TabIndex = 6;
            this.bt_remover.Text = "Remover";
            this.bt_remover.UseVisualStyleBackColor = true;
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listView1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(4, 48);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(174, 306);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // pnn_player
            // 
            this.pnn_player.Controls.Add(this.player);
            this.pnn_player.Location = new System.Drawing.Point(184, 48);
            this.pnn_player.Name = "pnn_player";
            this.pnn_player.Size = new System.Drawing.Size(403, 306);
            this.pnn_player.TabIndex = 19;
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(403, 306);
            this.player.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Location = new System.Drawing.Point(184, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // GerenciarMidia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 416);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnn_rodape);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnn_player);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lb_nomeCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.Name = "GerenciarMidia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inserção de Mídia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InserirMidia_FormClosed);
            this.pnn_rodape.ResumeLayout(false);
            this.pnn_player.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nomeCategoria;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnn_rodape;
        private System.Windows.Forms.Button bt_inserir;
        private System.Windows.Forms.Button bt_remover;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnn_player;
        public AxWMPLib.AxWindowsMediaPlayer player;
    }
}