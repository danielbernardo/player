namespace PlayIndoor
{
    partial class CriarCategoria
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
            this.lb_nomeCategoria = new System.Windows.Forms.Label();
            this.nome_categoria = new System.Windows.Forms.TextBox();
            this.btn_criar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_nomeCategoria
            // 
            this.lb_nomeCategoria.AutoSize = true;
            this.lb_nomeCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lb_nomeCategoria.ForeColor = System.Drawing.Color.Transparent;
            this.lb_nomeCategoria.Location = new System.Drawing.Point(12, 22);
            this.lb_nomeCategoria.Name = "lb_nomeCategoria";
            this.lb_nomeCategoria.Size = new System.Drawing.Size(35, 13);
            this.lb_nomeCategoria.TabIndex = 0;
            this.lb_nomeCategoria.Text = "Nome";
            // 
            // nome_categoria
            // 
            this.nome_categoria.Location = new System.Drawing.Point(53, 19);
            this.nome_categoria.Name = "nome_categoria";
            this.nome_categoria.Size = new System.Drawing.Size(234, 20);
            this.nome_categoria.TabIndex = 1;
            // 
            // btn_criar
            // 
            this.btn_criar.Location = new System.Drawing.Point(53, 54);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(75, 23);
            this.btn_criar.TabIndex = 2;
            this.btn_criar.Text = "Criar";
            this.btn_criar.UseVisualStyleBackColor = true;
            this.btn_criar.Click += new System.EventHandler(this.btn_criar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(134, 54);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // CriarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(303, 98);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_criar);
            this.Controls.Add(this.nome_categoria);
            this.Controls.Add(this.lb_nomeCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(309, 122);
            this.MinimizeBox = false;
            this.Name = "CriarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar Categoria";
            this.Load += new System.EventHandler(this.CriarCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nomeCategoria;
        private System.Windows.Forms.TextBox nome_categoria;
        private System.Windows.Forms.Button btn_criar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}