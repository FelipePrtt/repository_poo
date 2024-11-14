using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrataControleDepartamento
{
    public class Assalariado : Funcionario
    {
        //Construtores
        public Assalariado()
        {}
        public Assalariado(string nome, string cpf, double salario, Endereco endereco) : base(nome, cpf, salario, endereco)
        {
            Nome = nome;
            cpf = cpf;
            Salario = salario;
            Codigo = prox_cod++;
            Endereco = endereco;
        }

        //Métodos
        public override double calcularSalario(int diasUteis)
        {
            return (Salario / 30) * diasUteis; 
        }
    }
}