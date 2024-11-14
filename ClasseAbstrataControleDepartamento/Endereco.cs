using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrataControleDepartamento
{
    public class Endereco
    {
        // Atributos
        private string rua;
        private string numero; //Foi optado por deixar como string para atender numeros com complementos, numeros como "219-A", sem necessitar de outra variavel;
        private string cidade;


        // Sets e gets
        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        public string Numero
        {
            get { return numero; }
            set { numero = value;}
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value;}
        }

        // Construtores
        public Endereco()
        {}

        public Endereco(string rua, string numero, string bairro, string cidade)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
        }
    }
}