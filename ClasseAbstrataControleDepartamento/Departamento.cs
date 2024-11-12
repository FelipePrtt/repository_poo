using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrataControleDepartamento
{
    public class Departamento
    {
        //atributos
        private int codigo;
        private string descricao;
        

        //gets e sets
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }


        //métodos
        public double calcularFolhaPagamento(int diasUteis)
        {

        }
    }
}