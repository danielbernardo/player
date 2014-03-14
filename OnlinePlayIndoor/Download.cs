using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace OnlinePlayIndoor
{
    class Download
    {
        
        private string localPath;    //Pasta onde arquivo baixado será salvo
        private string fileRemote;   //Nome do arquivo remoto a ser baixado
        private string nameFileSave; //Nome que o arquivo terá após ser baixado
        private string folder;       //Pasta remota caso arquivo não esteja na raiz do ftp

        /* Arquivo Começam os métodos get e set de cada atributo */

        public void setLocalPath(string localPath)
        {
            this.localPath = localPath;
        }
        public string getLocalPath()
        {
            return this.localPath;
        }

        public void setFileRemote(string fileRemote)
        {
            this.fileRemote = fileRemote;
        }
        public string getFileRemote()
        {
            return this.fileRemote;
        }

        public void setNameFileSave(string fileSave)
        {
            this.nameFileSave = fileSave;
        }
        public string getNameFileSave()
        {
            return this.nameFileSave;
        }

        public void setFolder(string folder)
        {
            this.folder = folder;
        }
        public string getFolder()
        {
            return this.folder;
        }
        /********fim dos metodos get e set*********/


/***********************Aqui começa o método baixar********************************************/
        
        public void Baixar()
        {
            FtpWebRequest reqFTP; //Definindo um objeto re requisição para o ftp

            try
            {
                /*Definindo o canal de download, atribuindo o local de salvamento do arquivo 
                  Criação, e o nome que o arquivo terá ao ser salvo*/

                FileStream outputStream = new FileStream(getLocalPath() + "\\" +
                getNameFileSave(), FileMode.Create);

                /*Verifica se se o arquivo está na raiz ou então fará o download do diretório atribuído.*/
                if (getFolder() == null)
                {

                    /*Nas linhas abaixo informe seu servidor ftp em "host"*/
                    reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + "host" + "/" + getFileRemote()));

                }
                else
                {
                    reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + "host" + "/" + getFolder() + "/" + getFileRemote()));
                }

                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;


                reqFTP.UseBinary = true;

                /*Recebendo o usuário e senha do ftp*/
                reqFTP.Credentials = new NetworkCredential("user", "password");


                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();


                Stream ftpStream = response.GetResponseStream();


                long cl = response.ContentLength;



                int bufferSize = 4096; //Definindo o tamanho do buffer


                int readCount;


                byte[] buffer = new byte[bufferSize];



                readCount = ftpStream.Read(buffer, 0, bufferSize);


                while (readCount > 0)
                {
                    outputStream.Write(buffer, 0, readCount);


                    readCount = ftpStream.Read(buffer, 0, bufferSize);

                }
                if (readCount == 0)
                {

                    //MessageBox.Show("Parabéns, Download Concluído com Sucesso!", "Mensagem");

                }
                ftpStream.Close();


                outputStream.Close();


                response.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");

            }
        }


    }
}
