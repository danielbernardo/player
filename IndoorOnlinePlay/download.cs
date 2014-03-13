using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace IndoorOnlinePlay
{
    class download
    {       
            private string localPath;
            private string fileRemote;
            private string nameFileSave;
            private string folder;

            public void setLocalPath(string localPath)
            {
                this.localPath = localPath;

            }

            public void setFileRemote(string fileRemote)
            {
                this.fileRemote = fileRemote;
            }

            public void setNameFileSave(string fileSave)
            {
                this.nameFileSave = fileSave;
            }

            public void setFolder(string folder)
            {
                this.folder = folder;
            }

            public string getLocalPath()
            {
                return this.localPath;
            }
            public string getFileRemote()
            {
                return this.fileRemote;
            }
            public string getNameFileSave()
            {
                return this.nameFileSave;
            }
            public string getFolder()
            {
                return this.folder;
            }

            public void Baixar()
            {
                FtpWebRequest reqFTP;
                
                try
                {

                    FileStream outputStream = new FileStream(getLocalPath() + "\\" +
                    getNameFileSave(), FileMode.Create);


                    if (getFolder() == null)
                    {
                        //Abaixo deve ser passado o host no lugar de "seuhost" manualmente. será implementado arquivo conf.
                        reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + "seuhost" + "/" + getFileRemote()));

                    }
                    else
                    {   //Abaixo deve ser passado o host manualmente. será implementado arquivo conf.
                        reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + "seuhost" + "/" + getFolder() + "/" + getFileRemote()));
                    }

                    reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;


                    reqFTP.UseBinary = true;

                    /*
                       O comando abaixo nessida de um host ftp. atualmente deve ser inserido manualmente.
                     * Será criado arquivo de configuração para passar host e senha
                     */
                    reqFTP.Credentials = new NetworkCredential("seuhost", "senha");



                    FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();


                    Stream ftpStream = response.GetResponseStream();


                    long cl = response.ContentLength;



                    int bufferSize = 4096;


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

                        MessageBox.Show("Parabéns, Download Concluído com Sucesso!", "Mensagem");

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

