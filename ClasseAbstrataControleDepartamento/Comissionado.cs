using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrataControleDepartamento
{
    public class Comissionado : Funcionario
    {
        //atributos
        private double comissao = 0.20;

        //get e sets
        public double Comissao
        {
            get { return comissao; }
            set { comissao = value; }
        }

        //Construtores
        public Comissionado(string nome, double salario, Endereco endereco) : base(nome, salario, endereco)
        {
            Nome = nome;
            Salario = salario;
            Codigo = prox_cod++;
            Endereco = endereco;
            Comissao = comissao;
        }
        //métodos
        public override double calcularSalario(int diasUteis)
        {
            return ((Salario / 30) * diasUteis) * (comissao + Salario);
        }
    }
}