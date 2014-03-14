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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void cADASTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            CriarCategoria cad = new CriarCategoria();
            cad.ShowDialog();
        }

        private void bt_playPrincipal_Click(object sender, EventArgs e)
        {
            GerarListas();
            rep frmRep = new rep();
            frmRep.ShowDialog();

            
        }

        public void GerarListas()
        {
            DirectoryInfo Diretorio = new DirectoryInfo(@"C:\Pasta");

            //DirectoryInfo Diretorio = new DirectoryInfo(@"Files");//caso queira usar a pasta padrão

            DirectoryInfo[] SubDiretorio = Diretorio.GetDirectories();

            foreach (DirectoryInfo dir in SubDiretorio)
            {
                FileInfo[] arquivos = dir.GetFiles("*.*");

                if (arquivos.Length > 0)
                {

                    List<string> listagem = new List<string>();

                    foreach (FileInfo f in arquivos)
                    {

                        listagem.Add(f.ToString());

                    }

                    CreatePlayList(listagem, dir.ToString());
                    listagem.Clear();

                }
                
               
            }

            createPrincipalList();
        }

        public void createPrincipalList()
        {
            List<string> li = new List<string>();
            
            DirectoryInfo  Diretorio = new DirectoryInfo(@"C:\Pasta");

            //DirectoryInfo Diretorio = new DirectoryInfo(@"Files");//criar na pasta que o sistema está
           
            FileInfo[] arq = Diretorio.GetFiles("*.*");

            foreach (FileInfo f in arq)
            {
                li.Add(f.ToString());
            }

            CreatePlayList2(li);
        }

        public void CreatePlayList2(List<string> lista)
        {
            StreamWriter sw;

            // Open a file to write
            string sFileName = "ListaPrincipal.wpl";
            FileStream fs = File.Create(sFileName);
            sw = new StreamWriter(fs);

            string fileLine;
            // string sFileExt;

            try
            {
                sw.WriteLine("<?wpl version=\"1.0\"?>");    // File Header
                sw.WriteLine("<smil>");                     // Start of File Tag

                sw.WriteLine("\t<head>");                     // Playlist File Header Information Start Tag
                sw.WriteLine("\t\t<meta name=\"Generator\" content=\"Microsoft Windows Media Player -- 10.0.0.4036\"/>");
                sw.WriteLine("\t\t<author>" + "Daniel Bernardo" + "</author>");
                sw.WriteLine("\t\t<title>" + "Vídeos de Publicidade" + "</title>");
                sw.WriteLine("\t</head>");                    // Playlist File Header Information End Tag

                sw.WriteLine("\t<body>");                     // Start of body Tag
                sw.WriteLine("\t\t<seq>");                      // Start of filelist Tag

                for (int i = 0; i < lista.Count; i++)
                {

                    fileLine = "\t\t\t<media src=\"";

                    fileLine = fileLine + @"C:\Pasta"; // Adicionando novo caminho

                    fileLine = fileLine + lista[i].ToString() + "\"/>";
                    
                    sw.WriteLine(fileLine);

                }

                // Get Directory's File list and Add files
                // DirectoryListing(txtDir.Text);

                sw.WriteLine("\t\t</seq>");                      // End of filelist Tag
                sw.WriteLine("\t</body>");                    // End of body Tag
                sw.WriteLine("</smil>");                    // End of File Tag

                sFileName = sFileName + " Successfully created.";

                // MessageBox.Show(sFileName, "Create Playlis");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Create Playlist: Error");

                sFileName = sFileName + " Unsuccessful.";

                // MessageBox.Show(sFileName, "Create Playlis");
            }
            finally
            {
                sw.Close();
                fs.Close();
            }
        }


        public void CreatePlayList(List<string> lista,string nome)
        {
            StreamWriter sw;

            // Open a file to write

            string sFileName = nome + ".wpl";

            FileStream fs = File.Create(@"C:\Pasta\" + sFileName); // Criando arquivo na pasta c:

            //FileStream fs = File.Create(@"Files\" + sFileName);

            sw = new StreamWriter(fs);

            string fileLine;

            // string sFileExt;

            try
            {
                sw.WriteLine("<?wpl version=\"1.0\"?>");    // File Header

                sw.WriteLine("<smil>");                     // Start of File Tag

                sw.WriteLine("\t<head>");                     // Playlist File Header Information Start Tag

                sw.WriteLine("\t\t<meta name=\"Generator\" content=\"Microsoft Windows Media Player -- 10.0.0.4036\"/>");

                sw.WriteLine("\t\t<author>" + "Daniel Bernardo" + "</author>");

                sw.WriteLine("\t\t<title>" + "Vídeos de Publicidade" + "</title>");

                sw.WriteLine("\t</head>");                    // Playlist File Header Information End Tag

                sw.WriteLine("\t<body>");                     // Start of body Tag

                sw.WriteLine("\t\t<seq>");                      // Start of filelist Tag

                for (int i = 0; i < lista.Count; i++)
                {

                    fileLine = "\t\t\t<media src=\"";
                   
                    fileLine = fileLine + @"C:\Pasta\" + nome + @"\";

                    fileLine = fileLine + lista[i].ToString() + "\"/>";

                    sw.WriteLine(fileLine);

                }

                // Get Directory's File list and Add files
                // DirectoryListing(txtDir.Text);

                sw.WriteLine("\t\t</seq>");                      // End of filelist Tag

                sw.WriteLine("\t</body>");                    // End of body Tag

                sw.WriteLine("</smil>");                    // End of File Tag

                sFileName = sFileName + " Successfully created.";

                // MessageBox.Show(sFileName, "Create Playlis");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Create Playlist: Error");

                sFileName = sFileName + " Unsuccessful.";

                // MessageBox.Show(sFileName, "Create Playlis");
            }
            finally
            {
                sw.Close();
                fs.Close();
            }
        }

        private void iNSERIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciarMidia gerente = new GerenciarMidia();
            gerente.ShowDialog();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Pasta");
            //DirectoryInfo dir = new DirectoryInfo(@"Files");//buscar arquivo na pasta raiz do sistema
            try
            {
                // Determine whether the directory exists.
                if (!dir.Exists)
                {
                    dir.Create();
                    MessageBox.Show("Diretorio para Armazenamento das mídias não existia e foi criado com sucesso!","Criação de Diretório");
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema na Criação do Arquivo, Verifiques as Permissões do Diretório @QiPlayer\"",ex.ToString());
                
            }
          
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCategoria rem = new RemoveCategoria();
            rem.ShowDialog();
        }

    }
}
