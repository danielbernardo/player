using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PlayIndoor
{
    public partial class CriarCategoria : Form
    {
        public CriarCategoria()
        {
            InitializeComponent();
        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            if (nome_categoria.Text == "")
            {
                MessageBox.Show("Nome da Categoria não foi preenchido, Preencha por favor e clique novamente no botão Criar", "Problema ao Criar Categoria");
            }
            else
            {
                CriarPastaCategoria();
            }
            
        }

        public void CriarPastaCategoria()
        {
            string pasta = @"C:\Pasta\" + nome_categoria.Text;

            try
            {

                if (!Directory.Exists(pasta))
                {
                    Directory.CreateDirectory(pasta);
                    
                    MessageBox.Show("Cetegoria " +  nome_categoria.Text +    " Criado com Sucesso ");
                    nome_categoria.Text = "";
                }
                else
                {
                    MessageBox.Show("Já Existe Categoria Com Este Nome, Informe outro nome","Problema ao Criar Categoria");
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CriarCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
