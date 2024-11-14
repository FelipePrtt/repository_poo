using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrataControleDepartamento
{
    public abstract class Funcionario
    {
        //atributos
        private static int prox_cod = 0001;
        protected string nome;
        protected double salario;
        protected int codigo;
        protected Endereco();

        //gets e sets
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        //métodos
        public abstract double calcularSalario(int diasUteis);
    }
}