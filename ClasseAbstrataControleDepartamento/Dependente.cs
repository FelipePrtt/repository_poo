using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrataControleDepartamento
{
    public class Dependente
    {
        //Atributos
        private string nome;
        private int idade;
        private int codigo;

        //gets e sets
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        //Construtores
        public Dependente()
        {}
        public Dependente(string nome, int idade, int codigo)
        {
            Nome = nome;
            Idade = idade;
            Codigo = codigo;
        }

        //Métodos
        public bool verificarMaiorIdade()
        {
            if (Idade < 18)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}