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
            return Salario / 30 * diasUteis * Comissao + Salario;
        }
                public override int calcularTotalDependentes()
        {
            int totalDep = 0;
            foreach (Dependente d in Dependentes)
            {
                totalDep++;
            }
             return totalDep;
        }
        public override void cadastrarDependente(Dependente d)
        {
            Dependentes.Add(d);
        }
        public override void removerDependente(int codDep)
        {
            Dependente depRemover = null;

            for (int i = 0; i < Dependentes.Count; i++)
            {
                if (Dependentes[i].Codigo == codDep )
                {
                    depRemover = Dependentes[i];
                    break;
                }
            }
            if (depRemover != null)
            {
                if (depRemover.verificarMaiorIdade())
                    Dependentes.Remove(depRemover);
            }
            else
            {
                Console.WriteLine("Dependente não encontrado!");
            }
        }
        public override void listarDependentes()
        {
            foreach (Dependente d in Dependentes)
            {
                Console.WriteLine($"Nome: {d.Nome}, Idade: {d.Idade}");
            }
        }
    }
}