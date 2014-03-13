using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;

namespace IndoorOnlinePlay
{
    class Xml
    {
        public void createNode(string vId, string vTitulo, string vName, string vAtivo, XmlTextWriter writer)
        {

            writer.WriteStartElement("Video");


            writer.WriteStartElement("videoId");

            writer.WriteString(vId);

            writer.WriteEndElement();


            writer.WriteStartElement("VideoTitulo");

            writer.WriteString(vTitulo);

            writer.WriteEndElement();


            writer.WriteStartElement("VideoName");

            writer.WriteString(vName);

            writer.WriteEndElement();

            writer.WriteStartElement("VideoAtivo");

            writer.WriteString(vAtivo);

            writer.WriteEndElement();


            writer.WriteEndElement();

        }


 

        public void geraXML()
        {
            XmlTextWriter writer = new XmlTextWriter("listaLocal.xml", System.Text.Encoding.UTF8);

            writer.WriteStartDocument(true);

            writer.Formatting = Formatting.Indented;

            writer.Indentation = 2;

            writer.WriteStartElement("Table");

            string id, titulo, video, ativo;

            //deve ser preenchino os parâmetros de conexao ser = "hostbanco", user="userbanco","pwd="senhabanco",database = "nomeBanco"
            MySqlConnection conexao = new MySqlConnection("server=hostbanco;user id=userbanco;pwd=senhabanco;database=nomeBanco");

            //Nessa linha de comando é usado uma query para buscar os vídeos tidos como ativo no banco de dados
            MySqlCommand sql = new MySqlCommand("select *from videos where ativo = 'S'", conexao);

            try
            {
                conexao.Open();

                MySqlDataReader ler = sql.ExecuteReader();

                //Console.WriteLine("Listando dados....");

                while (ler.Read())
                {
                    //Console.WriteLine(ler["id"] + " " + ler["titulo"] + " " + ler["video"] + " " + ler["ativo"]);
                    //Console.WriteLine(ler.GetInt32(0) + ler.GetInt32(1) + ler.GetInt32(2) + ler.GetInt32(3));

                    /*if (ler.GetInt32(1) == 1)
                    {

                        string n = ler.GetString(3);

                        MessageBox.Show(n, "Resultado");
                    }*/

                    id = ler.GetInt32(0).ToString();
                    titulo = ler.GetString(2);
                    video = ler.GetString(3);
                    ativo = ler.GetString(4);

                     createNode(id, titulo, video, ativo, writer);

                }


                ler.Close();
                conexao.Close();
                //Console.ReadKey();

            }
            catch (MySqlException ex)
            {

                Console.WriteLine("Erro de conexao" + ex);
                //Console.ReadKey();

            }

            //createNode("1", "Video2", "video2.avi","S", writer);

            writer.WriteEndElement();

            writer.WriteEndDocument();

            writer.Close();

            MessageBox.Show("XML File created ! ");

        }


        public void geraXMLLimpo()
        {
            XmlTextWriter writer = new XmlTextWriter("listaLocal.xml", System.Text.Encoding.UTF8);

            writer.WriteStartDocument(true);

            writer.Formatting = Formatting.Indented;

            writer.Indentation = 2;

            writer.WriteStartElement("Table");

            //string id=null, titulo=null, video=null, ativo=null;

            //createNode(id, titulo, video, ativo, writer);

            //createNode("1", "Video2", "video2.avi","S", writer);

            writer.WriteEndElement();

            writer.WriteEndDocument();

            writer.Close();

            MessageBox.Show("XML File created ! ");

        }

      
 
    }
}
