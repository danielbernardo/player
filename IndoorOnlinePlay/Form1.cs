using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;
using MySql.Data.MySqlClient;//Precisa ser feito a instalação do MySql Connector
using System.Xml;
using System.Collections;

namespace IndoorOnlinePlay
{
    public partial class IndoorOnlinePlay : Form
    {
        public class video
        {
            private int id;
            private string nome;

            public void setId(int id)
            {
                this.id = id;
            }
            public void setNome(string nome)
            {
                this.nome = nome;
            }
            public int getId()
            {
                return this.id;
            }
            public string getNome()
            {
                return this.nome;
            }
       }
        
        public List<video> ListaVideoXml = new List<video>();
        public List<video> ListaVideoBanco = new List<video>();
        public List<string> listaDown = new List<string>();
        public static StreamWriter sw;

        public IndoorOnlinePlay()
        {
            InitializeComponent();
        }

        private void IndoorOnlinePlay_Load(object sender, EventArgs e)
        {
            //lerXml();
            //verificaVideo();
           

            
            if(!File.Exists(@"listaLocal.xml"))
            {
                Xml arquivo = new Xml();
                arquivo.geraXMLLimpo();

            }

            CreatePlayList();
           // qiplay.URL = @"C:\Qi\play.wpl";
          this.qiplay.URL = @"play.wpl";
            this.qiplay.settings.setMode("loop", true);   
        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            //Função de Comparação entre xml e Banco (comparar ids que existem no banco e não,
            
            //existem no XML.
            
            //Salvar resultado em vetor, ou lista

            //usar lista ou vetor com resultado da comparação e criar laço.

            //Executar laço para fazer download de todos os vídeos que faltam

            //Ler XML novamente para criar nova playlist

            //Reexecutar a playlist

            lerXml();
            
            verificaVideo();

            comparaBdXML();

            if (listaDown.Count > 0)
            {
                for (int i = 0; i < listaDown.Count; i++)
                {
                    download video = new download();

                    video.setFileRemote(listaDown[i].ToString());//Passar nome do arquivo para baixar

                    //Aqui deve ser inserido a sua pasta de videos do servidor ftp
                    video.setFolder("public_html/pastaderaquivos/videos");

                    video.setLocalPath(@"videos");//Pasta Local para Salvar Vídeo Baixado

                    video.setNameFileSave(video.getFileRemote());//Nome do arquivo após ser baixado

                    video.Baixar();
                }

                Xml file = new Xml();

                file.geraXML();

                //qiplay.URL = @"C:\Qi\play.wpl";
                this.qiplay.URL = @"play.wpl";
                this.qiplay.settings.setMode("loop", true);
                CreatePlayList();

            }
            else
            {
                MessageBox.Show("Lista Vazia");
            }

            

            //download video = new download();

            /*video.setFileRemote("nexus.avi");//Passar nome do arquivo para baixar
                
            video.setFolder("play/songs");
                
            video.setLocalPath(@"C:\Qi");//Pasta Local para Salvar Vídeo Baixado
                
            video.setNameFileSave(video.getFileRemote());//Nome do arquivo após ser baixado
                
            video.Baixar();
             * */
        }

        public void lerXml()
        {
            string sCaminhoDoArquivo = @"listaLocal.xml";
            
            XmlDocument xmlDoc = new XmlDocument();
            
            xmlDoc.Load(sCaminhoDoArquivo); //Carregando o arquivo
            
            XmlNodeList xnList = xmlDoc.GetElementsByTagName("Video");

            ListaVideoXml.Clear();
            
            foreach (XmlNode xn in xnList)
            {

                video v = new video(); 
               v.setId(int.Parse(xn["videoId"].InnerText));
               v.setNome(xn["VideoName"].InnerText);

              // VideoInfo.Add(v);
               
                ListaVideoXml.Add(v);
              
               //countVideoXML++;
                
            }

            for (int i = 0; i < ListaVideoXml.Count; i++)
            {


                 MessageBox.Show(ListaVideoXml[i].getId().ToString()+ " " + ListaVideoXml[i].getNome(),"Videos Cadastros no XML");
               
                 //video p = (video)VideoInfo[i];
                
                //MessageBox.Show("Existem " +  + " vídeos no arquivo XML", "Quantidade XML");   
            }
        }

        private void CreatePlayList()
        {
            // Open a file to write
            string sFileName = "play.wpl";
            FileStream fs = File.Create(sFileName);
            sw = new StreamWriter(fs);

            string fileLine;
           // string sFileExt;

            lerXml();

            try
            {
                sw.WriteLine("<?wpl version=\"1.0\"?>");    // File Header
                sw.WriteLine("<smil>");                     // Start of File Tag

                sw.WriteLine("\t<head>");                     // Playlist File Header Information Start Tag
                sw.WriteLine("\t\t<meta name=\"Generator\" content=\"Microsoft Windows Media Player -- 10.0.0.4036\"/>");
                sw.WriteLine("\t\t<author>" + "Daniel Bernardo" + "</author>");
                sw.WriteLine("\t\t<title>" +  "Vídeos de Publicidade" + "</title>");
                sw.WriteLine("\t</head>");                    // Playlist File Header Information End Tag

                sw.WriteLine("\t<body>");                     // Start of body Tag
                sw.WriteLine("\t\t<seq>");                      // Start of filelist Tag

                for (int i = 0; i < ListaVideoXml.Count; i++)
                {

                    fileLine = "\t\t\t<media src=\"";
                    //fileLine = fileLine + @"..\..\..\..\..\Qi\";
                    fileLine = fileLine + @"videos\";
                    fileLine = fileLine + ListaVideoXml[i].getNome() + "\"/>";
                    sw.WriteLine(fileLine);
                
                }

                // Get Directory's File list and Add files
               // DirectoryListing(txtDir.Text);

                sw.WriteLine("\t\t</seq>");                      // End of filelist Tag
                sw.WriteLine("\t</body>");                    // End of body Tag
                sw.WriteLine("</smil>");                    // End of File Tag

                sFileName = sFileName + " Successfully created.";

                MessageBox.Show(sFileName, "Create Playlist");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Create Playlist: Error");

                sFileName = sFileName + " Unsuccessful.";

                MessageBox.Show(sFileName, "Create Playlis");
            }
            finally
            {
                sw.Close();
                fs.Close();
            }
        }

       private void verificaVideo()
       {
          //deve ser preenchino os parâmetros de conexao ser = "hostbanco", user="userbanco","pwd="senhabanco",database = "nomeBanco"
           MySqlConnection conexao = new MySqlConnection("server=hostbanco;user id=userbanco;pwd=senhabanco;database=nomeBanco");

           //Nessa linha de comando é usado uma query para buscar os vídeos tidos como ativo no banco de dados
           MySqlCommand sql = new MySqlCommand("select *from videos where ativo = 'S'", conexao);
           
           //MySqlCommand sql = new MySqlCommand("select count(id) qtd from videos where ativo = 'S'", conexao);
            
           try
           {
                conexao.Open();

                MySqlDataReader ler = sql.ExecuteReader();

                ListaVideoBanco.Clear(); 

                while (ler.Read())
                {
                    video v = new video();
                   
                    v.setId(ler.GetInt32(0));
                    v.setNome(ler.GetString(3));
                   
                    ListaVideoBanco.Add(v);
                    
                    //qtdvideobd = ler.GetInt32(0);

                    //Console.WriteLine(ler["id"] + " " + ler["titulo"] + " " + ler["video"] + " " + ler["ativo"]);
                    //Console.WriteLine(ler.GetInt32(0) + ler.GetInt32(1) + ler.GetInt32(2) + ler.GetInt32(3));
                }

                for (int i = 0; i < ListaVideoBanco.Count; i++)
                {

                    MessageBox.Show(ListaVideoBanco[i].getId().ToString() + " " + ListaVideoBanco[i].getNome(),"Videos cadastrados no banco");

                }
              
            
                ler.Close();
                conexao.Close();
                
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Erro de conexao, Comunique ao Desenvolvedor. " + ex);
               

            }
        }


       public void comparaBdXML()
       {
               bool sn = false;

               for (int i = 0; i < ListaVideoBanco.Count; i++)
               {
                   for (int j = 0; j < ListaVideoXml.Count; j++)
                   {
                       if (ListaVideoBanco[i].getId() == ListaVideoXml[j].getId())
                       {
                           j = ListaVideoXml.Count;
                           sn = true;
                       }
                       else
                       {
                           sn = false;
                       }
                   }

                   if (sn == false)
                   {
                       listaDown.Add(ListaVideoBanco[i].getNome());
                       //MessageBox.Show(listaDown[i].ToString(), "Video Não Contem XML");
                   }
               }
           
       }

       private void timer1_Tick(object sender, EventArgs e)
       {
           if (this.backgroundWorker1.IsBusy)
           {
               timer1.Interval += timer1.Interval;
           }
           else
           {
               backgroundWorker1.RunWorkerAsync();
           }
       }

      
    }
}


