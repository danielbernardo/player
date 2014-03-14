using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;
using MySql.Data;


namespace OnlinePlayIndoor
{
    class Xml
    {
        /*Esta classe é responsável pela criação do xml. Nela encontra-se 
          Apenas métodos que executam esta função.
        */

        /*Método para criação dos elmentos do xml*/
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

        /*Método específico para gerar o xml, Nele é feito a leitura dos dados e criado os elementos
          Ao ser chamado a função createNode()
        */

        public void geraXML()
        {
            /*Objeto xml que define codificação do xml e nome do arquivo*/
            XmlTextWriter writer = new XmlTextWriter("listaLocal.xml", System.Text.Encoding.UTF8);

            writer.WriteStartDocument(true);

            writer.Formatting = Formatting.Indented;

            writer.Indentation = 2;

            writer.WriteStartElement("Table");

            /*Variaveis intermediárias onde serão salvo os dados de cada tupla do banco de dados*/
            string id, titulo, video, ativo;

            /*Este método faz conexão com um banco de dados mysql de onde serão gerados os elementos do xml
              * user id:   usuario_banco_de_dados
              * pwd :   senha_user_banco
              * database: banco_de_dados
             
             */
            MySqlConnection conexao = new MySqlConnection("server=host;user id=user;pwd=password;database=database");

            /*Busca dos elementos do banco de dados*/
            MySqlCommand sql = new MySqlCommand("select *from videos where ativo = 'S'", conexao);

            try
            {
                conexao.Open();

                MySqlDataReader ler = sql.ExecuteReader();

                /*Laço que irá percorrer o elemento ler enquanto tiver dados da consulta*/
                while (ler.Read())
                {
                    /*Salvando os dados da consulta em variaveis*/
                    id = ler.GetInt32(0).ToString();
                    titulo = ler.GetString(2);
                    video = ler.GetString(3);
                    ativo = ler.GetString(4);

                    /*Criando o elemento do xml com os dados salvo nas variaveis*/
                    createNode(id, titulo, video, ativo, writer);

                }


                ler.Close();      /*Fechando o elemento da consulta*/
                conexao.Close();  /*Fechando a consulta*/
            
          
            }catch (MySqlException ex){

                /*Mensagem do tratamento de erro caso ocorra no momento da conexão*/
                Console.WriteLine("Erro de conexao" + ex);
            }

            writer.WriteEndElement(); /*Final finalização do elemento*/

            writer.WriteEndDocument(); /*Finalização do documento*/

            writer.Close(); /*fechamento do canal de escrita*/

            //MessageBox.Show("XML File created ! ");

        }

        /*Método para gerar xml caso não exista no momento da abertura do software*/
        public void geraXMLLimpo()
        {
            XmlTextWriter writer = new XmlTextWriter("listaLocal.xml", System.Text.Encoding.UTF8);

            writer.WriteStartDocument(true);

            writer.Formatting = Formatting.Indented;

            writer.Indentation = 2;

            writer.WriteStartElement("Table");

            writer.WriteEndElement();

            writer.WriteEndDocument();

            writer.Close();

            //MessageBox.Show("XML File created ! ");

        }
    }
}
