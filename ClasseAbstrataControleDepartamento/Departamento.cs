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
        public List<Funcionario> VetFuncionarios {get; set;}
        

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

        //Construtores
        public Departamento()
        {}
        public Departamento(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }

        //métodos
        public double calcularFolhaPagamento(int diasUteis)
        { 
            double gastosTotais = 0;
            foreach (Funcionario f in VetFuncionarios)
            {
                gastosTotais += f.CalcularSalario(diasUteis);
            }
            return gastosTotais
        }
        public void admitirFuncionario(Funcionario funcionario)
        {
            VetFuncionarios.add(funcionario);
        }
        public void demitirFuncionario(int id)
        {
            foreach (Funcionario f in VetFuncionarios)
            {
                if (f.Codigo = id)
                {
                    VetFuncionarios.Remove(f);
                    Console.WriteLine($"Funcionário removido.");
                }
                else
                {
                    Console.WriteLine($"Código do funcionário não foi encontrado!");
                }
            }
        }
        public void listaFuncionarios()
        {
            foreach (Funcionario f in VetFuncionarios)
            {
                Console.WriteLine($"Nome: {f.Nome}\t Salário: {f.Salario}");
            }
        }
    }
}