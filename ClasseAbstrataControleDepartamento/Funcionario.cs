using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrataControleDepartamento
{
    public abstract class Funcionario
    {
        //atributos
        public static int prox_cod = 1;
        protected string nome;
        protected double salario;
        protected int codigo;
        protected Endereco endereco;
        protected List<Dependente> Dependentes { get; set; }

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
        public Endereco Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        //Construtores
        public Funcionario()
        {
            Dependentes = new List<Dependente>();
        }
        public Funcionario(string nome, double salario, Endereco endereco)
        {
            Nome = nome;
            Salario = salario;
            Endereco = endereco;
            Dependentes = new List<Dependente>();
        }
        //métodos
        public abstract double calcularSalario(int diasUteis);
        public abstract int calcularTotalDependentes();
        public abstract void cadastrarDependente(Dependente novoDependente);
        public abstract void removerDependente(int codDependente);
        public abstract void listarDependentes();

    }
}