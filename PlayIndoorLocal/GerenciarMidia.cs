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
    public partial class GerenciarMidia : Form
    {
        public GerenciarMidia()
        {
            InitializeComponent();
            
            DirectoryInfo pasta = new DirectoryInfo(@"C:\Pasta");
            
            DirectoryInfo[] subPastas = pasta.GetDirectories();

            foreach (DirectoryInfo dir in subPastas)
            {
                comboBox1.Items.Add(dir.ToString());

                comboBox1.SelectedItem = dir.ToString();
            }
            
            ShowItemsOfDirectory(@"C:\Pasta\" + comboBox1.SelectedItem);
          
            listView1.View = View.Tile;
        }

        public List<string> listaMedia = new List<string>(); 

        private void ShowItemsOfDirectory(string directory)
        {
            DirectoryInfo currentDirectory = new DirectoryInfo(directory);
            
            FileInfo[] files = currentDirectory.GetFiles("*.*");

            listView1.Items.Clear();
            
            listView1.BeginUpdate();

            foreach (FileInfo file in files)
            {

                ListViewItem item = new ListViewItem();
                item.Text = file.Name;
                item.ImageIndex = 1;

                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem();
                subitem.Text = file.LastAccessTime.ToString();
                item.SubItems.Add(subitem);

                subitem = new ListViewItem.ListViewSubItem();
                subitem.Text = (file.Length / 1000) + " KB";
                item.SubItems.Add(subitem);
                listaMedia.Add(file.ToString());
                listView1.Items.Add(item);
            }

            listView1.EndUpdate();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
             ShowItemsOfDirectory(@"C:\Pasta\" + comboBox1.SelectedItem);
             listView1.View = View.Tile;
        }

        private void bt_inserir_Click(object sender, EventArgs e)
        {
                try
                {
                    OpenFileDialog fdlg = new OpenFileDialog();

                    fdlg.Title = "Adicionar Arquivo de Mídia ";
                    fdlg.InitialDirectory = @"C:\";
                    fdlg.Filter = "Arquivo de Mídia(*.jpg;*.jpeg;*.bmp;*.png;*.mp3;*.wmv;*.wma;*.avi)|*.jpg;*.jpeg;*.bmp;*.png;*.mp3;*.wmv;*.wma;*.avi";
                    fdlg.FilterIndex = 2;
                    fdlg.Multiselect = true;
                    //string strPath;
                    string arq;

                    if (fdlg.ShowDialog() == DialogResult.OK)
                    {
                        foreach (string fileName in fdlg.FileNames)
                        {
                            //strPath = fileName;//fdlg.FileName;
                            arq = Path.GetFileName(fileName);
                            
                            File.Copy(fileName, @"C:\pasta\" + comboBox1.SelectedItem + @"\ " + arq, true);
                            
                            ShowItemsOfDirectory(@"C:\Pasta\" + comboBox1.SelectedItem);
                            
                            listView1.View = View.Tile;

                        }
                       
                    }

                }
                catch (Exception em)
                {

                    MessageBox.Show(em.Message.ToString());
                }
            
        }

        private void bt_remover_Click(object sender, EventArgs e)
        {

            string fileDelete;

            for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
            {
                try
                {

                    ListViewItem li = listView1.SelectedItems[i];
                    fileDelete = li.Text;

                    player.URL = "";

                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = null;
                    }


                    DialogResult a = MessageBox.Show("Deseja Mesmo Deletar?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);

                    if (a == DialogResult.Yes)
                    {
                        //pictureBox1.Image.Dispose();
                        pictureBox1.Image = null;
                        File.Delete(@"C:\Pasta\" + comboBox1.SelectedItem + @"\" + fileDelete);
                        listView1.Items.Remove(li);

                    }  

                }
                catch (Exception excessao)
                {

                    MessageBox.Show(excessao.Message.ToString(), "Problema ao Deletar");
                }
            }
        }

        string ext;

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
            {
                ListViewItem li = listView1.SelectedItems[i];

                ext = Path.GetExtension(@"C:\Pasta\" + comboBox1.SelectedItem + @"\" + li.Text);
                
                if (ext == ".mp3" || ext == ".wmv" || ext == ".avi")
                {
                    pnn_player.BringToFront();
                    
                    player.URL = @"C:\Pasta\" + comboBox1.SelectedItem + @"\" + li.Text;

                }
                else
                {
                    player.URL = "";

                    pictureBox1.BringToFront();
                    
                    Image imagem = Image.FromFile(@"C:\Pasta\" + comboBox1.SelectedItem + @"\" + li.Text);
                  
                    pictureBox1.Image = imagem;
                }
            }
        }

        private void InserirMidia_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
