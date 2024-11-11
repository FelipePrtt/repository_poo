using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrataControleDepartamento
{
    public abstract class Funcionario
    {
        //atributos
        protected string nome;
        protected double salario;
        protected int codigo;
        protected string endereco;

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