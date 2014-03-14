using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlinePlayIndoor
{
    /*Classe dos objetos que serão comparados entre banco de dados e xml */
    public class Video
    {
        private int id;     //Atributo utilizado para comparação
        private string nome;//Atributo utilizado para baixar o arquivo

        /*Métodos get e set*/
        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return this.id;
        }
    
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }

    }
}
