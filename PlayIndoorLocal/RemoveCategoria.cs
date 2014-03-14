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
    public partial class RemoveCategoria : Form
    {
        public RemoveCategoria()
        {
            InitializeComponent();

            ShowItemsOfDirectory(@"C:\Pasta");
            listView1.View = View.Tile;
        }

        private void ShowItemsOfDirectory(string directory)
        {
            DirectoryInfo currentDirectory = new DirectoryInfo(directory);
            DirectoryInfo[] subdirectories = currentDirectory.GetDirectories("*.*");

            listView1.Items.Clear();
            listView1.BeginUpdate();
            
            foreach (DirectoryInfo dir in subdirectories)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dir.Name;
                item.ImageIndex = 0;

                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem();
                subitem.Text = dir.LastAccessTime.ToString();
                item.SubItems.Add(subitem);

                subitem = new ListViewItem.ListViewSubItem();
                subitem.Text = String.Empty;
                item.SubItems.Add(subitem);

                listView1.Items.Add(item);
            }

            listView1.EndUpdate();
        }

        private void bt_Click(object sender, EventArgs e)
        {
            string fileDelete;

            for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
            {
                try
                {

                    ListViewItem li = listView1.SelectedItems[i];
                    fileDelete = li.Text;

                    DialogResult a = MessageBox.Show("A Remoção desta categoria, implicará na remoção de todas as mídias relacionadas a ela.\nTem Certeza que deseja removê-la ? ", "Confirmação de Exclusão", MessageBoxButtons.YesNo);

                    if (a == DialogResult.Yes)
                    {
                        Directory.Delete(@"C:\Pasta\" + fileDelete,true);
                       
                        listView1.Items.Remove(li);

                    }

                }
                catch (Exception excessao)
                {

                    MessageBox.Show(excessao.Message.ToString(), "Problema ao Deletar");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
