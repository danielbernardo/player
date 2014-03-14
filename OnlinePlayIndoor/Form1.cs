using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using MySql.Data.MySqlClient;
using System.Collections;


namespace OnlinePlayIndoor
{
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();
        }

        /*Lista para comparação dos vídeos entre banco de dados e xml*/
        
        public List<Video> ListaVideoXml = new List<Video>();  //Lista dos vídeos locais no xml
        public List<Video> ListaVideoBanco = new List<Video>();//Lista dos vídeos no banco de dados
        public List<string> listaDown = new List<string>();    // Lista resultado da comparação entre xml e banco
        
        /*Variavel de stream para salvar lista de vídeos*/
        public static StreamWriter sw;

        /*Função que carrega o programa as informações iniciais do programa*/
        private void QiPlayer_Load(object sender, EventArgs e)
        {
            /*Verifica caso tenha arquivo de xml criado*/
            if (!File.Exists(@"listaLocal.xml"))
            {
                /*Gera arquivo xml*/
                Xml arquivo = new Xml();
                arquivo.geraXMLLimpo();

            }

            this.qiplay.URL = @"play.wpl";      /*Atribui a lista de reprodução ao play de video*/
            this.qiplay.settings.setMode("loop", true); /*Coloca lista de reprodução em um loop*/   
        
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

                Video v = new Video();
                v.setId(int.Parse(xn["videoId"].InnerText));
                v.setNome(xn["VideoName"].InnerText);

                ListaVideoXml.Add(v);

            }
        }


        private void verificaVideo()
        {
            /*
              * Inicialmente realiza conexão com o banco, faz uma consulta para verificar vídeos ativos e se se existe novos vídeos inseridos.
              * Após a verificação, o sistema selecionará o nome dos novos vídeos e fazer o download dos mesmos junto ao servidor ftp
              * server: host_banco_de_dados
              * user id:   usuario_banco_de_dados
              * pwd :   senha_user_banco
              * database: banco_de_dados
              */
            MySqlConnection conexao = new MySqlConnection("server=host;user id=usser;pwd=password;database=database");

            //Adapte a query dependendo da estrutura do seu banco de dados
            MySqlCommand sql = new MySqlCommand("select *from videos where ativo = 'S'", conexao);

            try
            {
                conexao.Open();

                MySqlDataReader ler = sql.ExecuteReader();

                ListaVideoBanco.Clear();

                while (ler.Read())
                {
                    Video v = new Video();

                    v.setId(ler.GetInt32(0));
                    v.setNome(ler.GetString(3));

                    ListaVideoBanco.Add(v);

                    //qtdvideobd = ler.GetInt32(0);

                    //Console.WriteLine(ler["id"] + " " + ler["titulo"] + " " + ler["video"] + " " + ler["ativo"]);
                    //Console.WriteLine(ler.GetInt32(0) + ler.GetInt32(1) + ler.GetInt32(2) + ler.GetInt32(3));
                }

                /*
                for (int i = 0; i < ListaVideoBanco.Count; i++)
                {

                    MessageBox.Show(ListaVideoBanco[i].getId().ToString() + " " + ListaVideoBanco[i].getNome(), "Videos cadastrados no banco");

                }*/


                ler.Close();
                conexao.Close();

            }
            catch (MySqlException )
            {

                MessageBox.Show("Erro de conexao, Comunique ao Desenvolvedor");


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

            if (listaDown.Count == 0 && ListaVideoBanco.Count < ListaVideoXml.Count)
            {

                Xml file = new Xml();

               file.geraXML();
               CreatePlayList();
               this.qiplay.URL = @"play.wpl";
               this.qiplay.settings.setMode("loop", true);


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
                sw.WriteLine("\t\t<title>" + "Vídeos de Publicidade" + "</title>");
                sw.WriteLine("\t</head>");                    // Playlist File Header Information End Tag

                sw.WriteLine("\t<body>");                     // Start of body Tag
                sw.WriteLine("\t\t<seq>");                      // Start of filelist Tag

                for (int i = 0; i < ListaVideoBanco.Count; i++)
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

        private void backwork_DoWork(object sender, DoWorkEventArgs e)
        {

            lerXml(); /*Verificar os elementos do xml e atribuir a uma lista de objeto Video*/

            verificaVideo(); /*Verificar os lementos ativos do banco de dados e atribuir a uma outra lista de objetos Video*/

            comparaBdXML();  /*Comparar as duas lista geradas pelas funções anteriores*/

            /*Obs. O resultado da comparação das duas listas é a lista 'listaDown' */

            /*Caso não haja diferença nas listas será feito precessado a sequencia abaixo*/
            
            if (listaDown.Count > 0)
            {
                /*Executar o download de cada video com base na listaDown*/
                for (int i = 0; i < listaDown.Count; i++)
                {
                    Download video = new Download(); //Criar objeto novo de download

                    video.setFileRemote(listaDown[i].ToString());//Passar nome do arquivo para baixar

                    /*
                       No comando abaixo informe o diretorio ftp onde estarão os vídeos para serem baixados 
                    */

                    video.setFolder("public_html/folder/videos");//Pasta onde se encontra o arquivo de vídeo

                    video.setLocalPath(@"videos");//Pasta Local para Salvar Vídeo Baixado

                    video.setNameFileSave(video.getFileRemote());//Nome do arquivo após ser baixado

                    video.Baixar(); /*Executar método de download do vídeo*/
                }

                listaDown.Clear();

                /*Gerar novo xml com as informações novas do banco de dados*/
                Xml file = new Xml();

                file.geraXML();

                //qiplay.URL = @"C:\Qi\play.wpl";
                CreatePlayList();//Criar nova lista de reprodução
                this.qiplay.URL = @"play.wpl"; //Recarregar lista de reprodução
                this.qiplay.settings.setMode("loop", true); //Atribuir Loop para a lista
                
            }
            /*else
            {
                MessageBox.Show("Lista Vazia");
            }*/

        }



        /*Função de timer que verifica se existe vídeo novo no banco de dados*/
        private void TimerVerifica_Tick(object sender, EventArgs e)
        {
            /*Caso o trabalho de background esteja em execução, 
              o sistema incrementa o tempo do timer, caso contrário
              iniciar trabalho de background no horário  
            */

            if (this.backwork.IsBusy)
            {
                TimerVerifica.Interval += TimerVerifica.Interval;
            }
            else
            {
                backwork.RunWorkerAsync();
            }
        }

        private void QiPlayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
